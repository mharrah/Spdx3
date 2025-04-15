using Spdx3.Model.Core.Classes;
using Spdx3.Model.Lite;
using Spdx3.Model.Software.Classes;

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
            Name = "ABC Supply",
        };
        
        var package = new Package(TestCatalog, TestCreationInfo)
        {
            CopyrightText = "(c) 1999 Acme Industries",
            Name = "CoolPackage",
            PackageVersion = "1.0.0",
            SuppliedBy = supplier,
            DownloadLocation = @"C:\Users\Acme\Downloads\"
        };

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
        Assert.Equal(19, checker.Findings.Count);
        Assert.Equal(0, checker.Findings.Count(x => x.FindingType == LiteDomainComplianceFindingType.problem));
    }

    [Fact]
    public void Test_MinimallyRecommended_Catalog()
    {
        var spdxDocument = new SpdxDocument(TestCatalog, TestCreationInfo);
        var element = new IndividualElement(TestCatalog, TestCreationInfo);
        spdxDocument.Element.Add(element);
        spdxDocument.RootElement.Add(element);
        
        var checker = new LiteDomainComplianceChecker(TestCatalog);
        
        Assert.NotNull(checker);
        Assert.Empty(checker.Findings);
        Assert.True(checker.IsCompliant);
    }

}