using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Classes;

public class ElementCollectionTest : BaseModelTest
{
    [Fact]
    public void BrandNew_ElementCollection_SerializesProperly()
    {
        // Arrange
        var elementCollection = new ElementCollectionConcreteTestFixture(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "ElementCollectionConcreteTestFixture",
                                  "spdxId": "urn:ElementCollectionConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(elementCollection);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_ElementCollection_SerializesProperly()
    {
        // Arrange
        var elementCollection = new ElementCollectionConcreteTestFixture(TestCatalog, TestCreationInfo)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName"
        };
        elementCollection.Element.Add(new ElementConcreteTestFixture(TestCatalog, TestCreationInfo));
        elementCollection.Element.Add(new ElementConcreteTestFixture(TestCatalog, TestCreationInfo));
        elementCollection.RootElement.Add(new ElementConcreteTestFixture(TestCatalog, TestCreationInfo));
        elementCollection.ProfileConformance.Add(ProfileIdentifierType.security);

        const string expected = """
                                {
                                  "profileConformance": [
                                    "security"
                                  ],
                                  "rootElement": [
                                    "urn:ElementConcreteTestFixture:436"
                                  ],
                                  "element": [
                                    "urn:ElementConcreteTestFixture:41c",
                                    "urn:ElementConcreteTestFixture:429"
                                  ],
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "type": "ElementCollectionConcreteTestFixture",
                                  "spdxId": "urn:ElementCollectionConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(elementCollection);

        // Assert
        Assert.Equal(expected, json);
    }
}