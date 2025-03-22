using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Software.Classes;

public class SbomTest : BaseModelTest
{
    [Fact]
    public void Sbom_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var sbom = new Sbom(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "software_Sbom",
                                  "spdxId": "urn:Sbom:40f"
                                }
                                """;

        // Act
        var json = ToJson(sbom);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void Sbom_FullyPopulatedObject_ShouldSerialize()
    {
        // Arrange
        var sbom = new Sbom(TestCatalog, TestCreationInfo)
        {
            Comment = "Some comment",
            Description = "Some description",
            Name = "Some name",
            Summary = "Some summary"
        };
        sbom.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email,
            "example@example.com"));
        sbom.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        sbom.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.other));
        sbom.VerifiedUsing.Add(new Hash(TestCatalog, HashAlgorithm.sha1, "test hashvalue"));
        sbom.Element.Add(new ElementConcreteTestFixture(TestCatalog, TestCreationInfo));
        sbom.Context.Add("Some context");
        sbom.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        sbom.SbomType.Add(SbomType.build);
        const string expected = """
                                {
                                  "software_sbomType": [
                                    "build"
                                  ],
                                  "context": [
                                    "Some context"
                                  ],
                                  "element": [
                                    "urn:ElementConcreteTestFixture:450"
                                  ],
                                  "comment": "Some comment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "Some description",
                                  "extension": [
                                    "urn:ExtensionConcreteTestFixture:429",
                                    "urn:ExtensionConcreteTestFixture:45d"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:41c"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:436"
                                  ],
                                  "name": "Some name",
                                  "summary": "Some summary",
                                  "verifiedUsing": [
                                    "urn:Hash:443"
                                  ],
                                  "type": "software_Sbom",
                                  "spdxId": "urn:Sbom:40f"
                                }
                                """;

        // Act
        var json = ToJson(sbom);

        // Assert
        Assert.Equal(expected, json);
    }
}