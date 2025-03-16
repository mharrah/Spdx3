using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Serialization;
using Spdx3.Tests.Model;
using Spdx3.Tests.Model.SimpleLicensing.Classes;

namespace Spdx3.Tests.Serialization;

public class WriterTest : BaseModelTestClass
{
    [Fact]
    public void Writer_ShouldWrite_Minimal_SpdxDocument_AsString()
    {
        // Arrange
        // ReSharper disable once ObjectCreationAsStatement
#pragma warning disable CA1806
        new SpdxDocument(TestCatalog, TestCreationInfo);
#pragma warning restore CA1806

        const string expected = "{\"@context\":\"https://spdx.github.io/spdx-spec/v3.0.1/rdf/spdx-context.jsonld\"," +
                                "\"@graph\":[{\"created\":\"2025-02-22T01:23:45Z\",\"specVersion\":\"3.0.1\"," +
                                "\"type\":\"CreationInfo\",\"spdxId\":\"urn:CreationInfo:3f5\"}," +
                                "{\"creationInfo\":\"urn:CreationInfo:3f5\",\"type\":\"SpdxDocument\"," +
                                "\"spdxId\":\"urn:SpdxDocument:402\"}]}";
        var writer = new Writer(TestCatalog);

        // Act
        var json = writer.WriteString();

        // Assert
        Assert.NotNull(json);
        Assert.Equal(expected, json);
    }

    [Fact]
    public void Writer_ShouldWrite_SlightlyMoreComplex_SpdxDocument_AsString()
    {
        // Arrange
        var spdxDocument = new SpdxDocument(TestCatalog, TestCreationInfo)
        {
            Comment = "This is a comment",
            Description = "This is a description",
            Name = "This is a name",
            DataLicense = new TestAnyLicenseInfo(TestCatalog, TestCreationInfo)
        };
        spdxDocument.CreationInfo.CreatedBy.Add(new Person(TestCatalog, TestCreationInfo)
        {
            Name = "John Doe",
            Description = "A really swell guy",
            Comment = "But he owes me money",
            Summary = "How do I begin to summarize John Doe?"
        });
        var package = new Package(TestCatalog, TestCreationInfo)
        {
            Name = "Test Library Package",
            Description = "This is a Library"
        };
        var app = new Package(TestCatalog, TestCreationInfo)
        {
            Name = "Test App Package",
            Description = "This is an Application"
        };
        spdxDocument.Element.Add(package);
        spdxDocument.Element.Add(app);
        spdxDocument.Element.Add(new Relationship(TestCatalog, TestCreationInfo, RelationshipType.dependsOn, app,
            [package]));


        const string expected = """
                                {
                                    "@context":"https://spdx.github.io/spdx-spec/v3.0.1/rdf/spdx-context.jsonld",
                                    "@graph":[
                                        {
                                            "createdBy":[
                                                "urn:Person:41c"
                                            ],
                                            "created":"2025-02-22T01:23:45Z",
                                            "specVersion":"3.0.1",
                                            "type":"CreationInfo",
                                            "spdxId":"urn:CreationInfo:3f5"
                                        },
                                        {
                                            "dataLicense":"urn:TestAnyLicenseInfo:40f",
                                            "element":[
                                                "urn:Package:429",
                                                "urn:Package:436",
                                                "urn:Relationship:443"
                                            ],
                                            "comment":"This is a comment",
                                            "creationInfo":"urn:CreationInfo:3f5",
                                            "description":"This is a description",
                                            "name":"This is a name",
                                            "type":"SpdxDocument",
                                            "spdxId":"urn:SpdxDocument:402"
                                        },
                                        {
                                            "creationInfo":"urn:CreationInfo:3f5",
                                            "type":"simplelicensing_TestAnyLicenseInfo",
                                            "spdxId":"urn:TestAnyLicenseInfo:40f"
                                        },
                                        {
                                            "comment":"But he owes me money",
                                            "creationInfo":"urn:CreationInfo:3f5",
                                            "description":"A really swell guy",
                                            "name":"John Doe",
                                            "summary":"How do I begin to summarize John Doe?",
                                            "type":"Person",
                                            "spdxId":"urn:Person:41c"
                                        },
                                        {
                                            "creationInfo":"urn:CreationInfo:3f5",
                                            "description":"This is a Library",
                                            "name":"Test Library Package",
                                            "type":"software_Package",
                                            "spdxId":"urn:Package:429"
                                        },
                                        {
                                            "creationInfo":"urn:CreationInfo:3f5",
                                            "description":"This is an Application",
                                            "name":"Test App Package",
                                            "type":"software_Package",
                                            "spdxId":"urn:Package:436"
                                        },
                                        {
                                            "from":"urn:Package:436",
                                            "to":[
                                                "urn:Package:429"
                                            ],
                                            "relationshipType":"dependsOn",
                                            "creationInfo":"urn:CreationInfo:3f5",
                                            "type":"Relationship",
                                            "spdxId":"urn:Relationship:443"
                                        }
                                    ]
                                }
                                """;
        var writer = new Writer(TestCatalog);

        // Act
        var json = writer.WriteString();

        // Assert
        Assert.NotNull(json);
        Assert.Equal(NormalizeJson(expected), json);
    }
}