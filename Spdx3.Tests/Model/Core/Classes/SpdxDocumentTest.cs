using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Tests.Model.Extension.Classes;
using Spdx3.Tests.Model.SimpleLicensing.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class SpdxDocumentTest : BaseModelTest
{
    [Fact]
    public void SpdxDocument_FullyPopulatedElement_ShouldSerialize()
    {
        // Arrange
        var spdxDocument = new SpdxDocument(TestCatalog, TestCreationInfo)
        {
            DataLicense = new AnyLicenseInfoConcreteTestFixture(TestCatalog, TestCreationInfo),
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
        spdxDocument.RootElement.Add(new ElementConcreteTestFixture(TestCatalog, TestCreationInfo));
        spdxDocument.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        spdxDocument.Element.Add(new ElementConcreteTestFixture(TestCatalog, TestCreationInfo));
        spdxDocument.Import.Add(new ExternalMap(TestCatalog, "some-external-spdxid"));
        spdxDocument.NamespaceMap.Add(new NamespaceMap(TestCatalog, "some-prefix", new Uri("urn:some-namespace")));
        spdxDocument.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));
        const string expected = """
                                {
                                  "import": [
                                    "urn:ExternalMap:46a"
                                  ],
                                  "dataLicense": "urn:AnyLicenseInfoConcreteTestFixture:41c",
                                  "namespaceMap": [
                                    "urn:NamespaceMap:477"
                                  ],
                                  "profileConformance": [
                                    "ai",
                                    "build"
                                  ],
                                  "rootElement": [
                                    "urn:ElementConcreteTestFixture:443"
                                  ],
                                  "element": [
                                    "urn:ElementConcreteTestFixture:45d"
                                  ],
                                  "comment": "Test Comment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "Test Description",
                                  "extension": [
                                    "urn:ExtensionConcreteTestFixture:450"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:436"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:429"
                                  ],
                                  "name": "Test Name",
                                  "summary": "Test Summary",
                                  "verifiedUsing": [
                                    "urn:IntegrityMethodConcreteTestFixture:484"
                                  ],
                                  "type": "SpdxDocument",
                                  "spdxId": "urn:SpdxDocument:40f"
                                }
                                """;

        // Act
        var json = ToJson(spdxDocument);

        // Assert
        Assert.Equal(expected, json);
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
                                  "spdxId": "urn:SpdxDocument:40f"
                                }
                                """;

        // Act
        var json = ToJson(spdxDocument);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void SpdxDocument_NewElement_ShouldValidate()
    {
        var spdxDocument = new SpdxDocument(TestCatalog, TestCreationInfo);
        var exception = Record.Exception(() => spdxDocument.Validate());
        Assert.Null(exception);
    }
}