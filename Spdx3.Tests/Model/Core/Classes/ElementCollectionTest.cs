using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Classes;

public class ElementCollectionTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_ElementCollection_SerializesProperly()
    {
        // Arrange
        var elementCollection = new TestElementCollection(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "TestElementCollection",
                                  "spdxId": "urn:TestElementCollection:40f"
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
        var elementCollection = new TestElementCollection(TestCatalog, TestCreationInfo)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName"
        };
        elementCollection.Element.Add(new TestElement(TestCatalog, TestCreationInfo));
        elementCollection.Element.Add(new TestElement(TestCatalog, TestCreationInfo));
        elementCollection.RootElement.Add(new TestElement(TestCatalog, TestCreationInfo));
        elementCollection.ProfileConformance.Add(ProfileIdentifierType.security);

        const string expected = """
                                {
                                  "profileConformance": [
                                    "security"
                                  ],
                                  "rootElement": [
                                    "urn:TestElement:436"
                                  ],
                                  "element": [
                                    "urn:TestElement:41c",
                                    "urn:TestElement:429"
                                  ],
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "type": "TestElementCollection",
                                  "spdxId": "urn:TestElementCollection:40f"
                                }
                                """;

        // Act
        var json = ToJson(elementCollection);

        // Assert
        Assert.Equal(expected, json);
    }
}