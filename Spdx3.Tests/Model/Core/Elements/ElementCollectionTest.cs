using Spdx3.Model.Core.Enums;
using Spdx3.Tests.Model.Core.NonElements;

namespace Spdx3.Tests.Model.Core.Elements;

public class ElementCollectionTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_ElementCollection_SerializesProperly()
    {
        // Arrange
        var elementCollection = TestFactory.New<TestElementCollection>(TestCreationInfo);
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
        var elementCollection = TestFactory.New<TestElementCollection>(TestCreationInfo);
        elementCollection.Comment = "TestComment";
        elementCollection.Description = "TestDescription";
        elementCollection.Element.Add(TestFactory.New<TestElement>(TestCreationInfo));
        elementCollection.Element.Add(TestFactory.New<TestElement>(TestCreationInfo));
        elementCollection.Name = "TestName";
        elementCollection.RootElement.Add(TestFactory.New<TestElement>(TestCreationInfo));
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