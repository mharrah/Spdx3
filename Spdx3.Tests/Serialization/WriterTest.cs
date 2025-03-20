using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Serialization;
using Spdx3.Tests.Model;
using Spdx3.Tests.Model.SimpleLicensing.Classes;

namespace Spdx3.Tests.Serialization;

public class WriterTest : BaseModelTestClass
{
    private static readonly string ExpectedMinimalJson =
        "{\"@context\":\"https://spdx.github.io/spdx-spec/v3.0.1/rdf/spdx-context.jsonld\"," +
        "\"@graph\":[" +
        "{\"createdBy\":[\"urn:SoftwareAgent:402\"]," +
        "\"created\":\"2025-02-22T01:23:45Z\"," +
        "\"specVersion\":\"3.0.1\"," +
        "\"type\":\"CreationInfo\"," +
        "\"spdxId\":\"urn:CreationInfo:3f5\"}," +
        "{\"creationInfo\":\"urn:CreationInfo:3f5\"," +
        "\"name\":\"BaseModelTestClass constructor\"," +
        "\"type\":\"SoftwareAgent\"," +
        "\"spdxId\":\"urn:SoftwareAgent:402\"}," +
        "{\"creationInfo\":\"urn:CreationInfo:3f5\"," +
        "\"type\":\"SpdxDocument\"," +
        "\"spdxId\":\"urn:SpdxDocument:40f\"}" +
        "]}";

    [Fact]
    public void Writer_ShouldWrite_Minimal_SpdxDocument_AsString()
    {
        // Arrange
        // ReSharper disable once ObjectCreationAsStatement
#pragma warning disable CA1806
        new SpdxDocument(TestCatalog, TestCreationInfo);
#pragma warning restore CA1806

        var writer = new Writer(TestCatalog);

        // Act
        var json = writer.WriteString();

        // Assert
        Assert.NotNull(json);
        Assert.Equal(ExpectedMinimalJson, json);
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
                                                "urn:SoftwareAgent:402",
                                                "urn:Person:429"
                                            ],
                                            "created":"2025-02-22T01:23:45Z",
                                            "specVersion":"3.0.1",
                                            "type":"CreationInfo",
                                            "spdxId":"urn:CreationInfo:3f5"
                                        },
                                        {
                                            "creationInfo":"urn:CreationInfo:3f5",
                                            "name":"BaseModelTestClass constructor",
                                            "type":"SoftwareAgent",
                                            "spdxId":"urn:SoftwareAgent:402"
                                        },
                                        {
                                            "dataLicense":"urn:TestAnyLicenseInfo:41c",
                                            "element":[
                                                "urn:Package:436",
                                                "urn:Package:443",
                                                "urn:Relationship:450"
                                            ],
                                            "comment":"This is a comment",
                                            "creationInfo":"urn:CreationInfo:3f5",
                                            "description":"This is a description",
                                            "name":"This is a name",
                                            "type":"SpdxDocument",
                                            "spdxId":"urn:SpdxDocument:40f"
                                        },
                                        {
                                            "creationInfo":"urn:CreationInfo:3f5",
                                            "type":"simplelicensing_TestAnyLicenseInfo",
                                            "spdxId":"urn:TestAnyLicenseInfo:41c"
                                        },
                                        {
                                            "comment":"But he owes me money",
                                            "creationInfo":"urn:CreationInfo:3f5",
                                            "description":"A really swell guy",
                                            "name":"John Doe",
                                            "summary":"How do I begin to summarize John Doe?",
                                            "type":"Person",
                                            "spdxId":"urn:Person:429"
                                        },
                                        {
                                            "creationInfo":"urn:CreationInfo:3f5",
                                            "description":"This is a Library",
                                            "name":"Test Library Package",
                                            "type":"software_Package",
                                            "spdxId":"urn:Package:436"
                                        },
                                        {
                                            "creationInfo":"urn:CreationInfo:3f5",
                                            "description":"This is an Application",
                                            "name":"Test App Package",
                                            "type":"software_Package",
                                            "spdxId":"urn:Package:443"
                                        },
                                        {
                                            "from":"urn:Package:443",
                                            "to":[
                                                "urn:Package:436"
                                            ],
                                            "relationshipType":"dependsOn",
                                            "creationInfo":"urn:CreationInfo:3f5",
                                            "type":"Relationship",
                                            "spdxId":"urn:Relationship:450"
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

    [Fact]
    public void Writer_ShouldWrite_Minimal_SpdxDocument_AsFileStream()
    {
        // Arrange
        // ReSharper disable once ObjectCreationAsStatement
#pragma warning disable CA1806
        new SpdxDocument(TestCatalog, TestCreationInfo);
#pragma warning restore CA1806

        var writer = new Writer(TestCatalog);

        var tempFileName = Path.GetTempFileName();
        var fileStream = new FileStream(tempFileName, FileMode.Create);

        // Act
        writer.WriteFileStream(fileStream).Close();

        // Assert
        using var streamReader = new StreamReader(tempFileName);
        var json = streamReader.ReadToEnd();
        Assert.NotNull(json);
        Assert.Equal(NormalizeJson(ExpectedMinimalJson), json);
    }


    [Fact]
    public void Writer_ShouldWrite_Minimal_SpdxDocument_WithFileName()
    {
        // Arrange
        // ReSharper disable once ObjectCreationAsStatement
#pragma warning disable CA1806
        new SpdxDocument(TestCatalog, TestCreationInfo);
#pragma warning restore CA1806

        var writer = new Writer(TestCatalog);

        var tempFileName = Path.GetTempFileName();

        // Act
        writer.WriteFileName(tempFileName);

        // Assert
        using var streamReader = new StreamReader(tempFileName);
        var json = streamReader.ReadToEnd();
        Assert.NotNull(json);
        Assert.Equal(NormalizeJson(ExpectedMinimalJson), json);
    }
}