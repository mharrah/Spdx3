using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Classes;

public class ElementCollectionTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_ElementCollection_SerializesProperly()
    {
        // Arrange
        var elementCollection = new TestElementCollection(TestSpdxCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "TestElementCollection",
                                  "spdxId": "urn:TestElementCollection:402"
                                }
                                """;

        // Act
        var json = elementCollection.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_ElementCollection_SerializesProperly()
    {
        // Arrange
        var elementCollection = new TestElementCollection(TestSpdxCatalog, TestCreationInfo)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName"
        };
        elementCollection.Element.Add(new TestElement(TestSpdxCatalog, TestCreationInfo));
        elementCollection.Element.Add(new TestElement(TestSpdxCatalog, TestCreationInfo));
        elementCollection.RootElement.Add(new TestElement(TestSpdxCatalog, TestCreationInfo));
        elementCollection.ProfileConformance.Add(ProfileIdentifierType.security);

        const string expected = """
                                {
                                  "profileConformance": [
                                    "security"
                                  ],
                                  "rootElement": [
                                    "urn:TestElement:429"
                                  ],
                                  "element": [
                                    "urn:TestElement:40f",
                                    "urn:TestElement:41c"
                                  ],
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "type": "TestElementCollection",
                                  "spdxId": "urn:TestElementCollection:402"
                                }
                                """;

        // Act
        var json = elementCollection.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}