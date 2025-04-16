using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Utility;

public class CatalogTest
{
    [Fact]
    public void SpdxIdFactory_NewGeneratesId()
    {
        var spdxIdFactory = new Catalog();
        var id = spdxIdFactory.NewId(typeof(BaseModelClassConcreteTestFixture));
        Assert.NotNull(id);
        Assert.Matches("urn:BaseModelClassConcreteTestFixture:[0-9a-f]{3}", id.ToString());
    }

    [Fact]
    public void SpdxIdFactory_NewGeneratesAnother()
    {
        var spdxIdFactory = new Catalog();
        var id = spdxIdFactory.NewId(typeof(string));
        Assert.NotNull(id);
        Assert.Matches("urn:String:[0-9a-f]{3}", id.ToString());
    }

    [Fact]
    public void SpdxIdFactory_NewGeneratesDifferentIdsEachTime()
    {
        var spdxIdFactory = new Catalog();
        var id1 = spdxIdFactory.NewId(typeof(BaseModelClassConcreteTestFixture));
        var id2 = spdxIdFactory.NewId(typeof(BaseModelClassConcreteTestFixture));
        Assert.NotEqual(id1, id2);
    }

    [Fact]
    public void Catalog_GetRelationships_ReturnsAllRelationships()
    {
        // Arrange
        var catalog = GetPopulatedTestCatalog();

        // Act and Assert
        Assert.Equal(6, catalog.GetItems<Relationship>().Count);
    }


    [Fact]
    public void Catalog_GetRelationshipsFromType_ReturnsCorrectly()
    {
        // Arrange
        var catalog = GetPopulatedTestCatalog();

        // Act
        var fromTools = catalog.GetRelationshipsFrom<Tool>();
        var fromIndividuals = catalog.GetRelationshipsFrom<IndividualElement>();
        var fromPackages = catalog.GetRelationshipsFrom<Package>();
        var fromSboms = catalog.GetRelationshipsFrom<Sbom>();

        // Assert
        Assert.Equal(4, fromTools.Count);
        Assert.Single(fromIndividuals);
        Assert.Empty(fromPackages);
        Assert.Single(fromSboms);
    }


    [Fact]
    public void Catalog_GetRelationshipsFromElement_ReturnsCorrectly()
    {
        // Arrange
        var catalog = GetPopulatedTestCatalog();

        var tool1 = catalog.GetItems<Tool>().First(t => t.Name == "Tool1");
        var tool2 = catalog.GetItems<Tool>().First(t => t.Name == "Tool2");
        var tool3 = catalog.GetItems<Tool>().First(t => t.Name == "Tool3");
        var individual = catalog.GetItems<IndividualElement>().First();
        var package = catalog.GetItems<Package>().First();
        var sbom = catalog.GetItems<Sbom>().First();

        // Act
        var fromTool1 = catalog.GetRelationshipsFrom(tool1);
        var fromTool2 = catalog.GetRelationshipsFrom(tool2);
        var fromTool3 = catalog.GetRelationshipsFrom(tool3);
        var fromIndividual = catalog.GetRelationshipsFrom(individual);
        var fromPackage = catalog.GetRelationshipsFrom(package);
        var fromSbom = catalog.GetRelationshipsFrom(sbom);

        // Assert
        Assert.Single(fromTool1);
        Assert.Single(fromTool2);
        Assert.Equal(2, fromTool3.Count);
        Assert.Single(fromIndividual);
        Assert.Empty(fromPackage);
        Assert.Single(fromSbom);
    }

    [Fact]
    public void Catalog_GetRelationshipsToType_ReturnsCorrectly()
    {
        // Arrange
        var catalog = GetPopulatedTestCatalog();

        // Act
        var toTools = catalog.GetRelationshipsTo<Tool>();
        var toIndividuals = catalog.GetRelationshipsTo<IndividualElement>();
        var toPackages = catalog.GetRelationshipsTo<Package>();
        var toSboms = catalog.GetRelationshipsTo<Sbom>();

        // Assert
        Assert.Single(toTools);
        Assert.Empty(toIndividuals);
        Assert.Equal(5, toPackages.Count);
        Assert.Equal(2, toSboms.Count);
    }

    [Fact]
    public void Catalog_GetRelationshipsToElement_ReturnsCorrectly()
    {
        // Arrange
        var catalog = GetPopulatedTestCatalog();
        
        var tool1 = catalog.GetItems<Tool>().First(t => t.Name == "Tool1");
        var tool2 = catalog.GetItems<Tool>().First(t => t.Name == "Tool2");
        var tool3 = catalog.GetItems<Tool>().First(t => t.Name == "Tool3");
        var individual = catalog.GetItems<IndividualElement>().First();
        var package = catalog.GetItems<Package>().First();
        var sbom = catalog.GetItems<Sbom>().First();

        // Act
        var toTool1 = catalog.GetRelationshipsTo(tool1);
        var toTool2 = catalog.GetRelationshipsTo(tool2);
        var toTool3 = catalog.GetRelationshipsTo(tool3);
        var toIndividual = catalog.GetRelationshipsTo(individual);
        var toPackage = catalog.GetRelationshipsTo(package);
        var toSbom = catalog.GetRelationshipsTo(sbom);

        // Assert
        Assert.Single(toTool1);
        Assert.Empty(toTool2);
        Assert.Empty(toTool3);
        Assert.Empty(toIndividual);
        Assert.Equal(5, toPackage.Count);
        Assert.Equal(2, toSbom.Count);
    }
    
    [Fact]
    public void Catalog_GetRelationshipsFromToElement_ReturnsCorrectly()
    {
        // Arrange
        var catalog = GetPopulatedTestCatalog();

        // Act
        var fromToolsToPackages = catalog.GetRelationshipsFromTo<Tool, Package>();
        var fromIndividualsToPackages = catalog.GetRelationshipsFromTo<IndividualElement, Package>();
        var fromSbomsToTools = catalog.GetRelationshipsFromTo<Sbom, Tool>();
        var fromToolsToSboms = catalog.GetRelationshipsFromTo<Tool, Sbom>();

        // Assert
        Assert.Equal(3, fromToolsToPackages.Count);
        Assert.Single(fromIndividualsToPackages);
        Assert.Empty(fromSbomsToTools);
        Assert.Equal(2, fromToolsToSboms.Count);
    }
    [Fact]
    public void Catalog_GetRelationshipsFromToType_ReturnsCorrectly()
    {
        // Arrange
        var catalog = GetPopulatedTestCatalog();
        
        var tool1 = catalog.GetItems<Tool>().First(t => t.Name == "Tool1");
        var tool2 = catalog.GetItems<Tool>().First(t => t.Name == "Tool2");
        var tool3 = catalog.GetItems<Tool>().First(t => t.Name == "Tool3");
        var individual = catalog.GetItems<IndividualElement>().First();
        var package = catalog.GetItems<Package>().First();
        var sbom = catalog.GetItems<Sbom>().First();

        // Act
        var fromTool1ToPackage = catalog.GetRelationshipsFromTo(tool1, package);
        var fromTool2ToSbom = catalog.GetRelationshipsFromTo(tool2, sbom);
        var fromTool3ToPackage = catalog.GetRelationshipsFromTo(tool3, package);
        var fromIndividualToTool1 = catalog.GetRelationshipsFromTo(individual, tool1);
        var fromIndividualToTool2 = catalog.GetRelationshipsFromTo(individual, tool2);
        var fromSbomToTool1 = catalog.GetRelationshipsFromTo(sbom, tool1);
        var fromSbomToPackage = catalog.GetRelationshipsFromTo(sbom, package);
        var fromTool1ToSbom = catalog.GetRelationshipsFromTo(tool1, sbom);
        var fromTool3ToSbom = catalog.GetRelationshipsFromTo(tool3, sbom);

        // Assert
        Assert.Single(fromTool1ToPackage);
        Assert.Single(fromTool2ToSbom);
        Assert.Equal(2, fromTool3ToPackage.Count);
        Assert.Single(fromIndividualToTool1);
        Assert.Empty(fromIndividualToTool2);
        Assert.Empty(fromSbomToTool1);
        Assert.Single(fromSbomToPackage);
        Assert.Empty(fromTool1ToSbom);
        Assert.Single(fromTool3ToSbom);
    }
    
    /// <summary>
    /// Set up the test catalog with a bunch of objects and relationships
    /// </summary>
    private static Catalog GetPopulatedTestCatalog()
    {
        var catalog = new Catalog();

        // Make the CreationInfo object
        var creationInfo = new CreationInfo(catalog, DateTimeOffset.Now);
        creationInfo.CreatedBy.Add(new SoftwareAgent(catalog, creationInfo));

        // Make some objects
        var tool1 = new Tool(catalog, creationInfo) { Name = "Tool1" };
        var tool2 = new Tool(catalog, creationInfo) { Name = "Tool2" };
        var tool3 = new Tool(catalog, creationInfo) { Name = "Tool3" };
        var individual = new IndividualElement(catalog, creationInfo) { Name = "Individual" };
        var package = new Package(catalog, creationInfo) { Name = "Package" };
        var sbom = new Sbom(catalog, creationInfo) { Name = "SBOM" };

        // Create some relationships
        new Relationship(catalog, creationInfo, RelationshipType.generates, tool1, [package]);
        new Relationship(catalog, creationInfo, RelationshipType.generates, tool2, [sbom]);
        new Relationship(catalog, creationInfo, RelationshipType.dependsOn, individual, [tool1, package]);
        new Relationship(catalog, creationInfo, RelationshipType.describes, sbom, [package]);
        new Relationship(catalog, creationInfo, RelationshipType.hasOutput, tool3, [package, sbom]);
        new Relationship(catalog, creationInfo, RelationshipType.reportedBy, tool3, [package]);

        return catalog;
    }
}