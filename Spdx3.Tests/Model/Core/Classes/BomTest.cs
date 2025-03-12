using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Classes;

public class BomTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_Bom_SerializesProperly()
    {
        // Arrange
        var bom = new Bom(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Bom",
                                  "spdxId": "urn:Bom:402"
                                }
                                """;

        // Act
        var json = ToJson(bom);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Bom_SerializesProperly()
    {
        // Arrange
        var bom = new Bom(TestCatalog, TestCreationInfo)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName"
        };
        bom.Context.Add("Some context");
        bom.Context.Add("More context");
        bom.Element.Add(new TestElement(TestCatalog, TestCreationInfo));
        bom.Element.Add(new TestElement(TestCatalog, TestCreationInfo));
        bom.RootElement.Add(new TestElement(TestCatalog, TestCreationInfo));
        bom.ProfileConformance.Add(ProfileIdentifierType.security);

        const string expected = """
                                {
                                  "context": [
                                    "Some context",
                                    "More context"
                                  ],
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
                                  "type": "Bom",
                                  "spdxId": "urn:Bom:402"
                                }
                                """;

        // Act
        var json = ToJson(bom);

        // Assert
        Assert.Equal(expected, json);
    }
}