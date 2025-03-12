using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Software.Classes;

public class SbomTest : BaseModelTestClass
{
    [Fact]
    public void Sbom_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var sbom = new Sbom(TestSpdxCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "software_Sbom",
                                  "spdxId": "urn:Sbom:402"
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
        var sbom = new Sbom(TestSpdxCatalog, TestCreationInfo)
        {
            Comment = "Some comment",
            Description = "Some description",
            Name = "Some name",
            Summary = "Some summary"
        };
        sbom.ExternalIdentifier.Add(new ExternalIdentifier(TestSpdxCatalog, ExternalIdentifierType.email,
            "example@example.com"));
        sbom.Extension.Add(new TestExtension(TestSpdxCatalog));
        sbom.ExternalRef.Add(new ExternalRef(TestSpdxCatalog, ExternalRefType.other));
        sbom.VerifiedUsing.Add(new Hash(TestSpdxCatalog, HashAlgorithm.sha1, "test hashvalue"));
        sbom.Element.Add(new TestElement(TestSpdxCatalog, TestCreationInfo));
        sbom.Context.Add("Some context");
        sbom.Extension.Add(new TestExtension(TestSpdxCatalog));
        sbom.SbomType.Add(SbomType.build);
        const string expected = """
                                {
                                  "sbomType": [
                                    "build"
                                  ],
                                  "context": [
                                    "Some context"
                                  ],
                                  "element": [
                                    "urn:TestElement:443"
                                  ],
                                  "comment": "Some comment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "Some description",
                                  "extension": [
                                    "urn:TestExtension:41c",
                                    "urn:TestExtension:450"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:40f"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:429"
                                  ],
                                  "name": "Some name",
                                  "summary": "Some summary",
                                  "verifiedUsing": [
                                    "urn:Hash:436"
                                  ],
                                  "type": "software_Sbom",
                                  "spdxId": "urn:Sbom:402"
                                }
                                """;

        // Act
        var json = ToJson(sbom);

        // Assert
        Assert.Equal(expected, json);
    }
}