using System.Xml;
using ProduceSourceSbom.NuGetApi;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.ExpandedLicensing.Classes;
using Spdx3.Model.Lite;
using Spdx3.Model.Software.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace ProduceSourceSbom;

public class SbomBuilder
{
    private Catalog Catalog { get; } = new();
    private CreationInfo CreationInfo { get; }

    public SbomBuilder()
    {
        CreationInfo = new CreationInfo(Catalog)
        {
            Created = DateTimeOffset.UtcNow,
        };
        CreationInfo.CreatedUsing.Add(new Tool(Catalog, CreationInfo)
        {
            Name = $"{nameof(ProduceSourceSbom)}",
            Description = "Demonstration project in the SPDX3 source repository"
        });
    }

    private static void EchoOptions()
    {
        if (!Program.Verbose)
        {
            return;
        }
        Console.WriteLine("Options in use:");
        Console.WriteLine($"OutputDir = {Program.OutputDir}");
        Console.WriteLine($"FileName = {Program.FileName}");
        Console.WriteLine($"ProjectPath = {Program.ProjectPath}");
        Console.WriteLine($"LiteDomainComplianceMandatory = {Program.LiteDomainComplianceMandatory}");
        Console.WriteLine($"Verbose = {Program.Verbose}");
    }

    public void ProduceAllTheThings()
    {
        EchoOptions();

        if (!Program.ProjectPath.EndsWith(".csproj"))
        {
            Console.Error.WriteLine($"***ERROR*** Project path {Program.ProjectPath} is not a .csproj file.");
            Environment.Exit(1);
        }

        if (!new FileInfo(Program.ProjectPath).Exists)
        {
            Console.Error.WriteLine($"***ERROR*** Project path {Program.ProjectPath} does not exist.");
            Environment.Exit(2);
        }

        var fqOutputFile = Path.Join(Program.OutputDir, Program.FileName);
        Build();
        var catalog = Catalog;
        var f = new Writer(catalog).WriteFileName(fqOutputFile);

        if (Program.Verbose)
        {
            Console.WriteLine($"Wrote to {f.FullName}.");
        }
    }

    private void Build()
    {
        if (!new FileInfo(Program.ProjectPath).Exists)
        {
            Console.Error.WriteLine($"***ERROR*** The project file '{Program.ProjectPath}' does not exist.");
            Environment.Exit(3);
        }

        var author = BuildAuthor();
        var sbom = BuildSbom(author);
        BuildSpdxDocument(sbom);

        if (Program.LiteDomainComplianceMandatory)
        {
            CheckLiteDomainCompliance();
        }
    }

    private Person BuildAuthor()
    {
        var author = new Person(Catalog, CreationInfo)
        {
            Name = "Matt Harrah"
        };
        author.ExternalIdentifier.Add(new ExternalIdentifier(Catalog, ExternalIdentifierType.email,
            "github@mharrah.simplelogin.com"));
        CreationInfo.CreatedBy.Add(author);
        return author;
    }

    private Sbom BuildSbom(Person author)
    {
        var spdx3 = GetPackage(author);

        var sbom = new Sbom(Catalog, CreationInfo)
        {
            Name = "Spdx3"
        };
        sbom.SbomType.Add(SbomType.source);
        sbom.RootElement.Add(spdx3);
        sbom.Element.Add(spdx3);

        var deps = GetDependencies();

        foreach (var dep in deps)
        {
            sbom.Element.Add(dep);
            _ = new Relationship(Catalog, CreationInfo, RelationshipType.dependsOn, spdx3, [dep]);
        }

        return sbom;
    }

    private void BuildSpdxDocument(Sbom sbom)
    {
        var spdxDocument = new SpdxDocument(Catalog, CreationInfo)
        {
            Name = "Spdx3",
            DataLicense = ListedLicenses.MIT
        };
        spdxDocument.RootElement.Add(sbom);
        spdxDocument.Element.Add(sbom);
    }

    private void CheckLiteDomainCompliance()
    {
        var lite = new LiteDomainComplianceChecker(Catalog);

        if (!lite.IsCompliant)
        {
            Console.WriteLine("Catalog is not Lite domain compliant.");
            lite.Problems.ToList().ForEach(f => Console.WriteLine($"- {f}"));
            Console.Error.WriteLine("***ERROR*** Catalog is not Lite domain compliant.");
            Environment.Exit(4);
        }

        if (Program.Verbose)
        {
            Console.WriteLine("Catalog is Lite domain compliant.");
        }
    }

    private void EnrichPackageNodeWithNugetData(Package package)
    {
        if (package.Name is null || package.PackageVersion is null)
        {
            return;
        }

        var client = new Client();

        // Search for the package on nuget.org
        var nugetSearchResult = client.SearchForPackage(package.Name, package.PackageVersion);

        if (nugetSearchResult is null)
        {
            return;
        }
        // Go pull the registration for the package found
        var nugetRegistration =  client.GetPackageRegistration(nugetSearchResult);

        if (nugetRegistration is null)
        {
            return;
        }

        foreach (var catPage in nugetRegistration.CatalogPages ?? [])
        {
            foreach (var nugetPackage in catPage.Packages ?? [])
            {
                var cat = nugetPackage.CatalogEntry;
                if (package.Name != cat?.Id  || package.PackageVersion != cat?.Version) continue;

                package.Description = nugetSearchResult.Description;

                if (cat?.ProjectUrl is not null)
                {
                    package.HomePage = new Uri(cat.ProjectUrl);
                }

                if (cat?.LicenseExpression is not null)
                {
                    if (ListedLicenses.Licenses.ContainsKey(cat.LicenseExpression))
                    {
                        _ = new Relationship(Catalog, CreationInfo, RelationshipType.hasDeclaredLicense, package,
                            [ListedLicenses.Licenses[cat.LicenseExpression]]);
                        _ = new Relationship(Catalog, CreationInfo, RelationshipType.hasConcludedLicense, package,
                            [ListedLicenses.Licenses[cat.LicenseExpression]]);
                    }
                }

                package.DownloadLocation = nugetPackage.PackageContent;
            }
        }
    }

    private List<Package> GetDependencies()
    {
        List<Package> result = [];

        var doc = new XmlDocument();
        doc.Load(Program.ProjectPath);

        if (doc.DocumentElement is null)
        {
            return result;
        }
        var packageReferenceNodes = doc.DocumentElement.SelectNodes("//ItemGroup/PackageReference");

        if (packageReferenceNodes is null)
        {
            return result;
        }

        foreach (XmlNode packageReference in packageReferenceNodes)
        {
            if (packageReference is null)
            {
                continue;
            }
            var package = GetPackageFromPackageReference(packageReference);
            result.Add(package);

            if (string.IsNullOrWhiteSpace(package.PackageVersion) || string.IsNullOrWhiteSpace(package.Name))
            {
                continue;
            }

            EnrichPackageNodeWithNugetData(package);
        }

        return result;
    }

    private Package GetPackage(Person author)
    {
        var spdx3 = new Package(Catalog, CreationInfo)
        {
            DownloadLocation = "https://github.com/mharrah/spdx3.git",
            HomePage = new Uri("https://github.com/mharrah/spdx3"),
            CopyrightText = "(c) Copyright 2025 Matthew R Harrah",
            Name = "Spdx3",
            PackageUrl = new Uri("pkg:nuget/Spdx3@1.0.0"),
            PackageVersion = "1.0.0",
            SuppliedBy = author
        };
        spdx3.OriginatedBy.Add(author);
        spdx3.SupportLevel.Add(SupportType.noSupport);

        _ = new Relationship(Catalog, CreationInfo, RelationshipType.hasDeclaredLicense, spdx3, [ListedLicenses.MIT])
        {
            Completeness = RelationshipCompleteness.complete
        };
        _ = new Relationship(Catalog, CreationInfo, RelationshipType.hasConcludedLicense, spdx3, [ListedLicenses.MIT])
        {
            Completeness = RelationshipCompleteness.complete
        };
        return spdx3;
    }

    private Package GetPackageFromPackageReference(XmlNode packageReference)
    {
        var packageName = packageReference.Attributes?["Include"]?.Value;
        var packageVersion = packageReference.Attributes?["Version"]?.Value;

        return new Package(Catalog, CreationInfo)
        {
            Name = packageName,
            PackageVersion = packageVersion
        };
    }
}