using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.ExpandedLicensing.Individuals;
using Spdx3.Model.Lite;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Model.Software.Classes;
using Spdx3.Tests.Model.SimpleLicensing.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Lite;

public class LiteDomainComplianceCheckerTest : BaseModelTest
{
    [Fact]
    public void NewSpdxDocuments_AreNot_LiteDomainCompliant()
    {
        var spdxDocument = new SpdxDocument(TestCatalog, TestCreationInfo);

        var checker = new LiteDomainComplianceChecker(TestCatalog);

        Assert.NotNull(checker);
        Assert.NotEmpty(checker.Findings);
        Assert.False(checker.IsCompliant);
        Assert.Equal(10, checker.Findings.Count);
        Assert.Equal(3, checker.Findings.Count(x => x.FindingType == LiteDomainComplianceFindingType.problem));
    }

    [Fact]
    public void Test_MinimallyCompliant_Catalog()
    {
        // Arrange
        var supplier = new Organization(TestCatalog, TestCreationInfo)
        {
            Name = "ABC Supply"
        };

        var package = new Package(TestCatalog, TestCreationInfo)
        {
            CopyrightText = "(c) 1999 Acme Industries",
            Name = "CoolPackage",
            PackageVersion = "1.0.0",
            SuppliedBy = supplier,
            DownloadLocation = @"C:\Users\Acme\Downloads\"
        };

        new Relationship(TestCatalog, TestCreationInfo,RelationshipType.hasConcludedLicense, package,
            [new LicenseExpression(TestCatalog, TestCreationInfo, "this is a license")]); 
        new Relationship(TestCatalog, TestCreationInfo,RelationshipType.hasDeclaredLicense, package,
            [new LicenseExpression(TestCatalog, TestCreationInfo, "this is a license")]); 

        var sbom = new Sbom(TestCatalog, TestCreationInfo);
        sbom.Element.Add(package);
        sbom.RootElement.Add(package);

        var spdxDocument = new SpdxDocument(TestCatalog, TestCreationInfo);
        spdxDocument.Element.Add(sbom);
        spdxDocument.RootElement.Add(sbom);

        // Act
        var checker = new LiteDomainComplianceChecker(TestCatalog);

        // Assert
        Assert.NotNull(checker);
        Assert.NotEmpty(checker.Findings);
        Assert.True(checker.IsCompliant);
        Assert.Equal(21, checker.Findings.Count);
        Assert.Equal(0, checker.Findings.Count(x => x.FindingType == LiteDomainComplianceFindingType.problem));
    }

    [Fact]
    public void Test_MinimallyRecommended_Catalog()
    {
        // Arrange
        TestCreationInfo.Comment = "Comment goes here";
        TestCreationInfo.CreatedBy.First().ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog, ExternalIdentifierType.other, "externalId"));
        var supplier = new Organization(TestCatalog, TestCreationInfo)
        {
            Name = "ABC Supply"
        };
        supplier.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));

        var package = new Package(TestCatalog, TestCreationInfo)
        {
            CopyrightText = "(c) 1999 Acme Industries",
            Name = "CoolPackage",
            PackageVersion = "1.0.0",
            SuppliedBy = supplier,
            DownloadLocation = @"C:\Users\Acme\Downloads\",
            BuiltTime = PredictableDateTime,
            Comment = "Comment goes here",
            HomePage = new Uri(@"uri:homepage"),
            ReleaseTime = PredictableDateTime.AddHours(1),
            ValidUntilTime = PredictableDateTime.AddYears(1)
        };
        package.AttributionText.Add("attributed to something");
        package.SupportLevel.Add(SupportType.deployed);
        package.VerifiedUsing.Add(new Hash(TestCatalog, HashAlgorithm.md5, "54321")
            { Comment = "Hash comment goes here" });

        var sbom = new Sbom(TestCatalog, TestCreationInfo)
        {
            Comment = "Comment goes here",
            Name = "CoolPackage SBOM"
        };
        sbom.Element.Add(package);
        sbom.RootElement.Add(package);
        sbom.VerifiedUsing.Add(new Hash(TestCatalog, HashAlgorithm.md5, "12345")
            { Comment = "Hash comment goes here" });
        var spdxDocument = new SpdxDocument(TestCatalog, TestCreationInfo)
        {
            Comment = "Comment goes here",
            DataLicense = new NoneLicense(TestCatalog, TestCreationInfo),
            Name = "CoolPackage Spdx Document"
        };
        spdxDocument.Element.Add(sbom);
        spdxDocument.RootElement.Add(sbom);
        spdxDocument.NamespaceMap.Add(new NamespaceMap(TestCatalog, "pfx", new Uri("uri:someNamespaceUri")));
        spdxDocument.VerifiedUsing.Add(new Hash(TestCatalog, HashAlgorithm.sha1, "99999")
            { Comment = "Hash comment goes here" });

        var license = new LicenseExpression(TestCatalog, TestCreationInfo, "it's a license")
        {
            LicenseListVersion = "1.1.1"
        };
        new Relationship(TestCatalog, TestCreationInfo, RelationshipType.hasConcludedLicense, package, [license]);
        
        // Act
        var checker = new LiteDomainComplianceChecker(TestCatalog);
        
        // Assert
        Assert.NotNull(checker);
        Assert.Empty(checker.Findings);
        Assert.True(checker.IsCompliant);
    }
}