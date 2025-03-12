using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Tests.Model.Extension.Classes;
using Spdx3.Tests.Model.SimpleLicensing.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class SpdxDocumentTest : BaseModelTestClass
{
    [Fact]
    public void SpdxDocument_NewElement_ShouldValidate()
    {
        var spdxDocument = new SpdxDocument(TestCatalog, TestCreationInfo);
        var exception = Record.Exception(() => spdxDocument.Validate());
        Assert.Null(exception);
    }

    [Fact]
    public void SpdxDocument_NewElement_ShouldSerialize()
    {
        // Arrange
        var spdxDocument = new SpdxDocument(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "SpdxDocument",
                                  "spdxId": "urn:SpdxDocument:402"
                                }
                                """;

        // Act
        var json = ToJson(spdxDocument);

        // Assert
        Assert.Equal(expected, json);
    }


    [Fact]
    public void SpdxDocument_FullyPopulatedElement_ShouldSerialize()
    {
        // Arrange
        var spdxDocument = new SpdxDocument(TestCatalog, TestCreationInfo)
        {
            DataLicense = new TestAnyLicenseInfo(TestCatalog, TestCreationInfo),
            Comment = "Test Comment",
            Description = "Test Description",
            Name = "Test Name",
            Summary = "Test Summary"
        };
        spdxDocument.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.nuget));
        spdxDocument.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email,
            "email@amail.com"));
        spdxDocument.ProfileConformance.Add(ProfileIdentifierType.ai);
        spdxDocument.ProfileConformance.Add(ProfileIdentifierType.build);
        spdxDocument.RootElement.Add(new TestElement(TestCatalog, TestCreationInfo));
        spdxDocument.Extension.Add(new TestExtension(TestCatalog));
        spdxDocument.Element.Add(new TestElement(TestCatalog, TestCreationInfo));
        spdxDocument.Import.Add(new ExternalMap(TestCatalog, "some-external-spdxid"));
        spdxDocument.NamespaceMap.Add(new NamespaceMap(TestCatalog, "some-prefix", "some-namespace"));
        spdxDocument.VerifiedUsing.Add(new TestIntegrityMethod(TestCatalog));
        const string expected = """
                                {
                                  "import": [
                                    "urn:ExternalMap:45d"
                                  ],
                                  "dataLicense": "urn:TestAnyLicenseInfo:40f",
                                  "namespaceMap": [
                                    "urn:NamespaceMap:46a"
                                  ],
                                  "profileConformance": [
                                    "ai",
                                    "build"
                                  ],
                                  "rootElement": [
                                    "urn:TestElement:436"
                                  ],
                                  "element": [
                                    "urn:TestElement:450"
                                  ],
                                  "comment": "Test Comment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "Test Description",
                                  "extension": [
                                    "urn:TestExtension:443"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:429"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:41c"
                                  ],
                                  "name": "Test Name",
                                  "summary": "Test Summary",
                                  "verifiedUsing": [
                                    "urn:TestIntegrityMethod:477"
                                  ],
                                  "type": "SpdxDocument",
                                  "spdxId": "urn:SpdxDocument:402"
                                }
                                """;

        // Act
        var json = ToJson(spdxDocument);

        // Assert
        Assert.Equal(expected, json);
    }
}