using System.ComponentModel;
using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;
using Spdx3.Tests.Model.Core.NonElements;
using Spdx3.Tests.Model.Extension;
using Spdx3.Tests.Model.SimpleLicensing;

namespace Spdx3.Tests.Model.Core.Elements;

public class SpdxDocumentTest : BaseModelTestClass
{
    [Fact]
    public void SpdxDocument_NewElement_ShouldValidate()
    {
        var spdxDocument = new SpdxDocument(TestSpdxIdFactory, TestCreationInfo);
        var exception = Record.Exception(() => spdxDocument.Validate());
        Assert.Null(exception);
    }
    
    [Fact]
    public void SpdxDocument_NewElement_ShouldSerialize()
    {
        // Arrange
        var spdxDocument = new SpdxDocument(TestSpdxIdFactory, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "SpdxDocument",
                                  "spdxId": "urn:SpdxDocument:402"
                                }
                                """;
        
        // Act
        var json = spdxDocument.ToJson();
            
        // Assert
        Assert.Equal(expected, json);
    }


    [Fact]
    public void SpdxDocument_FullyPopulatedElement_ShouldSerialize()
    {
        // Arrange
        var spdxDocument = new SpdxDocument(TestSpdxIdFactory, TestCreationInfo)
        {
            DataLicense = new TestAnyLicenseInfo(TestSpdxIdFactory, TestCreationInfo),
            Comment = "Test Comment",
            Description = "Test Description",
            Name = "Test Name",
            Summary = "Test Summary",
        };
        spdxDocument.ExternalRef.Add(new ExternalRef(TestSpdxIdFactory, ExternalRefType.nuget));
        spdxDocument.ExternalIdentifier.Add(new ExternalIdentifier(TestSpdxIdFactory, ExternalIdentifierType.email, "email@amail.com"));
        spdxDocument.ProfileConformance.Add(ProfileIdentifierType.ai);
        spdxDocument.ProfileConformance.Add(ProfileIdentifierType.build);
        spdxDocument.RootElement.Add(new TestElement(TestSpdxIdFactory, TestCreationInfo));
        spdxDocument.Extension.Add(new TestExtension(TestSpdxIdFactory));
        spdxDocument.Element.Add(new TestElement(TestSpdxIdFactory, TestCreationInfo));
        spdxDocument.Import.Add(new ExternalMap(TestSpdxIdFactory, "some-external-spdxid"));
        spdxDocument.NamespaceMap.Add(new NamespaceMap(TestSpdxIdFactory, "some-prefix", "some-namespace"));
        spdxDocument.VerifiedUsing.Add(new TestIntegrityMethod(TestSpdxIdFactory));
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
        var json = spdxDocument.ToJson();
            
        // Assert
        Assert.Equal(expected, json);
    }

    
}