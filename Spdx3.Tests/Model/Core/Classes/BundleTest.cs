using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Classes;

public class BundleTest : BaseModelTest
{
    [Fact]
    public void BrandNew_Bundle_SerializesProperly()
    {
        // Arrange
        var bundle = new Bundle(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Bundle",
                                  "spdxId": "urn:Bundle:40f"
                                }
                                """;

        // Act
        var json = ToJson(bundle);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Bundle_SerializesProperly()
    {
        // Arrange
        var bundle = new Bundle(TestCatalog, TestCreationInfo)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName"
        };
        bundle.Context.Add("Some context");
        bundle.Context.Add("More context");
        bundle.Element.Add(new ElementConcreteTestFixture(TestCatalog, TestCreationInfo));
        bundle.Element.Add(new ElementConcreteTestFixture(TestCatalog, TestCreationInfo));
        bundle.RootElement.Add(new ElementConcreteTestFixture(TestCatalog, TestCreationInfo));
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
                                  "type": "Bundle",
                                  "spdxId": "urn:Bundle:40f"
                                }
                                """;

        // Act
        var json = ToJson(bundle);

        // Assert
        Assert.Equal(expected, json);
    }
}