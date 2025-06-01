using System.Xml;
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
    public required FileInfo ProjectPath { get; set; }
    private Catalog Catalog { get; init; } = new();
    private CreationInfo CreationInfo { get; set; }
    private bool LiteDomainComplianceMandatory { get; set; } = true;
    private bool Verbose { get; set; } = false;

    public SbomBuilder()
    {
        CreationInfo = new CreationInfo(Catalog);
    }

    public void ProduceAllTheThings(FileInfo outputDir, string fileName, FileInfo projectPath, bool verbose,
        bool liteDomainComplianceMandatory)
    {
        LiteDomainComplianceMandatory = liteDomainComplianceMandatory;
        ProjectPath = projectPath;
        Verbose = verbose;
        
        EchoOptions(outputDir, fileName, projectPath, verbose, liteDomainComplianceMandatory);

        if (!projectPath.FullName.EndsWith(".csproj"))
        {
            Console.Error.WriteLine($"Project path {projectPath} is not a .csproj file.");
            Environment.Exit(1);
        }

        if (!projectPath.Exists)
        {
            Console.Error.WriteLine($"Project path {projectPath} does not exist.");
            Environment.Exit(2);
        }

        var fqOutputFile = Path.Join(outputDir.FullName, fileName);
        Build();
        var catalog = Catalog;
        var f = new Writer(catalog).WriteFileName(fqOutputFile);

        if (verbose)
        {
            Console.WriteLine($"Wrote to {f.FullName}.");
        }
    }

    private void Build()
    {
        if (!ProjectPath.Exists)
        {
            Console.Error.WriteLine($"The project file '{ProjectPath.FullName}' does not exist.");
            Environment.Exit(3);
        }

        var author = BuildAuthor();
        var sbom = BuildSbom(author);
        BuildSpdxDocument(sbom);

        if (LiteDomainComplianceMandatory)
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
        deps.ForEach(dep => sbom.Element.Add(dep));
        sbom.Element.Add(new Relationship(Catalog, CreationInfo, RelationshipType.dependsOn, spdx3,
            deps.ConvertAll(Element (d) => d)));

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
            Console.Error.WriteLine("Catalog is not Lite domain compliant.");
            Environment.Exit(4);
        }

        if (Verbose)
        {
            Console.WriteLine("Catalog is Lite domain compliant.");
        }
    }

    private void EchoOptions(FileInfo outputDir, string fileName, FileInfo projectPath, bool verbose,
        bool liteDomainComplianceMandatory)
    {
        if (!verbose)
        {
            return;
        }
        Console.WriteLine("Options in use:");
        Console.WriteLine($"OutputDir = {outputDir.FullName}");
        Console.WriteLine($"FileName = {fileName}");
        Console.WriteLine($"ProjectPath = {projectPath}");
        Console.WriteLine($"LiteDomainComplianceMandatory = {liteDomainComplianceMandatory}");
        Console.WriteLine($"Verbose = {verbose}");
    }

    private List<Package> GetDependencies()
    {
        List<Package> result = [];

        var doc = new XmlDocument();
        doc.Load(ProjectPath.FullName);

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
            var packageName = packageReference.Attributes?["Include"]?.Value;
            var packageVersion = packageReference.Attributes?["Version"]?.Value;

            if (packageName is null || packageVersion is null)
            {
                continue;
            }

            // Look up info about each package on Nuget.org
            // (Invoke-RestMethod -Uri "https://api.nuget.org/v3/registration5-semver1/spdx3/0.9.2-preview.json")
            // DownloadUrl == 'packageContent'
            // Get the property 'catalogEntry' and pull that from Nuget.org
            // Copyright text == 'copyright'
            // SuppliedBy == author
            // 
            

            
            var package = new Package(Catalog, CreationInfo)
            {
                Name = packageName,
                PackageVersion = packageVersion,
                Comment = null,
                Description = null,
                Summary = null,
                BuiltTime = null,
                OriginatedBy = null,
                ReleaseTime = null,
                StandardName = null,
                SuppliedBy = null,
                SupportLevel = null,
                ValidUntilTime = null,
                CopyrightText = null,
                PrimaryPurpose = null,
                DownloadLocation = null,
                PackageUrl = null,
                HomePage = null,
                SourceInfo = null, 
            };
            result.Add(package);
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
            PackageUrl = new Uri("pkg:nuget/Spdx3@0.9.2-preview"),
            PackageVersion = "0.9.2-preview",
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
}