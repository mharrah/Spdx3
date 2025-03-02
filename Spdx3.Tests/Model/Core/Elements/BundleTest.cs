using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Elements;

public class BundleTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_Bundle_SerializesProperly()
    {
        // Arrange
        var bundle = new Bundle(TestSpdxIdFactory, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Bundle",
                                  "spdxId": "urn:Bundle:402"
                                }
                                """;

        // Act
        var json = bundle.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Bundle_SerializesProperly()
    {
        // Arrange
        var bundle = new Bundle(TestSpdxIdFactory, TestCreationInfo)
        {
          Comment = "TestComment",
          Description = "TestDescription",
          Name = "TestName"
        };
        bundle.Context.Add("Some context");
        bundle.Context.Add("More context");
        bundle.Element.Add(new TestElement(TestSpdxIdFactory, TestCreationInfo));
        bundle.Element.Add(new TestElement(TestSpdxIdFactory, TestCreationInfo));
        bundle.RootElement.Add(new TestElement(TestSpdxIdFactory, TestCreationInfo));
        bundle.ProfileConformance.Add(ProfileIdentifierType.security);

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
                                  "type": "Bundle",
                                  "spdxId": "urn:Bundle:402"
                                }
                                """;

        // Act
        var json = bundle.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}