using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Elements;

public class ElementCollectionTest : BaseElementTestClass
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
        elementCollection.ElementRef.Add("testRef1");
        elementCollection.ElementRef.Add("testRef2");
        elementCollection.Name = "TestName";
        elementCollection.RootElementRef.Add("testref");
        elementCollection.ProfileConformance.Add(ProfileIdentifierType.security);

        const string expected = """
                                {
                                  "profileConformance": [
                                    "security"
                                  ],
                                  "rootElement": [
                                    "testref"
                                  ],
                                  "element": [
                                    "testRef1",
                                    "testRef2"
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