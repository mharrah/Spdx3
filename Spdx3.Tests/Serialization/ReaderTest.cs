using System.Reflection;
using System.Text.Json;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Tests.Serialization;

public class ReaderTest
{
    private static string GetTestFilePath(string relativePath)
    {
        var codeBaseUrl = new Uri(Assembly.GetExecutingAssembly().Location);
        var codeBasePath = Uri.UnescapeDataString(codeBaseUrl.AbsolutePath);
        var dirPath = Path.GetDirectoryName(codeBasePath);
        return Path.Combine(dirPath ?? throw new Spdx3SerializationException("Could not find test file directory"),
            "TestFiles", relativePath);
    }

    [Fact]
    public void Reader_ArrayInPlaceOfSingleValue_ShouldThrow()
    {
        // Arrange
        const string json = """
                            {
                              "@context": "https://spdx.org/rdf/3.0.1/spdx-context.jsonld",
                              "@graph": [
                                {
                                  "created": "2025-02-22T01:23:45Z",
                                  "specVersion": "3.0.1",
                                  "type": "CreationInfo",
                                  "spdxId": "urn:CreationInfo:3f5"
                                },
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "SpdxDocument",
                                  "spdxId": "urn:SpdxDocument:402",
                                  "comment": [
                                    "only a single value is allowed here",
                                    "so this needs to throw an exception"
                                  ]
                                }
                              ]
                            }
                            """;

        var catalog = new Catalog();
        var reader = new Reader(catalog);

        // Act
        var exception = Record.Exception(() => reader.ReadString(json));

        // Assert
        Assert.NotNull(exception);
        Assert.IsType<Spdx3SerializationException>(exception);
        Assert.IsType<InvalidCastException>(exception.InnerException);
    }


    [Fact]
    public void Reader_BrokenReferenceLinks_ShouldThrow()
    {
        // Arrange - note that the spdxIDs for CreationInfo do not agree
        const string json = """
                            {
                              "@context": "https://spdx.org/rdf/3.0.1/spdx-context.jsonld",
                              "@graph": [
                                {
                                  "created": "2025-02-22T01:23:45Z",
                                  "specVersion": "3.0.1",
                                  "type": "CreationInfo",
                                  "spdxId": "urn:CreationInfo:3A5"
                                },
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "SpdxDocument",
                                  "spdxId": "urn:SpdxDocument:402"
                                }
                              ]
                            }
                            """;

        var catalog = new Catalog();
        var reader = new Reader(catalog);

        // Act
        var exception = Record.Exception(() => reader.ReadString(json));

        // Assert
        Assert.NotNull(exception);
        Assert.IsType<Spdx3Exception>(exception);
        Assert.Contains("Could not find catalog item with ID", exception.Message);
        Assert.Null(exception.InnerException);
    }


    [Fact]
    public void Reader_Malformed_MissingPropertyName_ShouldThrow()
    {
        // Arrange
        const string json = """
                            {
                              "@context": "https://spdx.org/rdf/3.0.1/spdx-context.jsonld",
                              "@graph": [
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  : "Value",
                                  "spdxId": "urn:SpdxDocument:402"
                                }
                              ]
                            }
                            """;

        var catalog = new Catalog();
        var reader = new Reader(catalog);

        // Act
        var exception = Record.Exception(() => reader.ReadString(json));

        // Assert
        Assert.NotNull(exception);
        Assert.IsType<JsonException>(exception);
        Assert.Contains("':' is an invalid start of a property name", exception.Message);
    }

    [Fact]
    public void Reader_Malformed_MissingValue_ShouldThrow()
    {
        // Arrange
        const string json = """
                            {
                              "@context": "https://spdx.org/rdf/3.0.1/spdx-context.jsonld",
                              "@graph": [
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": ,
                                  "spdxId": "urn:SpdxDocument:402"
                                }
                              ]
                            }
                            """;

        var catalog = new Catalog();
        var reader = new Reader(catalog);

        // Act
        var exception = Record.Exception(() => reader.ReadString(json));

        // Assert
        Assert.NotNull(exception);
        Assert.IsType<JsonException>(exception);
        Assert.Contains("',' is an invalid start of a value", exception.Message);
        Assert.NotNull(exception.InnerException);
    }


    [Fact]
    public void Reader_NestedObject_ShouldThrow()
    {
        // Arrange
        const string json = """
                            {
                              "@context": "https://spdx.org/rdf/3.0.1/spdx-context.jsonld",
                              "@graph": [
                                {
                                  "creationInfo": {
                                    "created": "2025-02-22T01:23:45Z",
                                    "specVersion": "3.0.1",
                                    "type": "CreationInfo",
                                    "spdxId": "urn:CreationInfo:3f5"
                                  },
                                  "type": "SpdxDocument",
                                  "spdxId": "urn:SpdxDocument:402"
                                }
                              ]
                            }
                            """;

        var catalog = new Catalog();
        var reader = new Reader(catalog);

        // Act
        var exception = Record.Exception(() => reader.ReadString(json));

        // Assert
        Assert.NotNull(exception);
        Assert.IsType<Spdx3SerializationException>(exception);
        Assert.Contains("nested object", exception.Message);
        Assert.Null(exception.InnerException);
    }

    [Fact]
    public void Reader_ReadsJsonFile()
    {
        // Arrange
        var jsonFile = GetTestFilePath("Acme Application.spdx3.0.1.json");

        // Act
        var catalog = new Catalog();
        var spdxDocument = new Reader(catalog).ReadFileName(jsonFile);

        // Assert
        Assert.Equal(53, catalog.Items.Count);
        Assert.Equal(11, catalog.Items.Values.Count(i => i.Type == "Relationship"));
        Assert.Equal(3, catalog.Items.Values.Count(i => i.Type == "Organization"));
        Assert.Equal(4, catalog.Items.Values.Count(i => i.Type == "Person"));
        Assert.Equal(1, catalog.Items.Values.Count(i => i.Type == "ai_AiPackage"));
        Assert.Equal(1, catalog.Items.Values.Count(i => i.Type == "build_Build"));

        Assert.NotNull(spdxDocument);
        Assert.NotEmpty(spdxDocument.Element);
        Assert.Equal(2, spdxDocument.ProfileConformance.Count);

        var creationInfo = (CreationInfo)catalog.Items.Values.First(v => v.Type == "CreationInfo");
        Assert.Equal(creationInfo, spdxDocument.CreationInfo);
        Assert.Equal(new DateTimeOffset(2024, 5, 2, 0, 0, 0, TimeSpan.Zero), creationInfo.Created);
    }

    [Fact]
    public void Reader_ReadsValid_JsonString()
    {
        const string json = """
                            {
                              "@context": "https://spdx.org/rdf/3.0.1/spdx-context.jsonld",
                              "@graph": [
                                {
                                  "created": "2025-02-22T01:23:45Z",
                                  "specVersion": "3.0.1",
                                  "type": "CreationInfo",
                                  "spdxId": "urn:CreationInfo:3f5"
                                },
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "SpdxDocument",
                                  "spdxId": "urn:SpdxDocument:402"
                                }
                              ]
                            }
                            """;

        var catalog = new Catalog();
        var spdxDocument = new Reader(catalog).ReadString(json);

        Assert.NotNull(spdxDocument);
        Assert.NotEmpty(spdxDocument.Element);
        Assert.Equal(2, catalog.Items.Count);
    }


    [Fact]
    public void Reader_SingleValueInPlaceOfArray_ShouldThrow()
    {
        // Arrange
        const string json = """
                            {
                              "@context": "https://spdx.org/rdf/3.0.1/spdx-context.jsonld",
                              "@graph": [
                                {
                                  "created": "2025-02-22T01:23:45Z",
                                  "specVersion": "3.0.1",
                                  "type": "CreationInfo",
                                  "spdxId": "urn:CreationInfo:3f5"
                                },
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "SpdxDocument",
                                  "spdxId": "urn:SpdxDocument:402",
                                  "createdBy": "single-value-in-place-of-array"
                                }
                              ]
                            }
                            """;

        var catalog = new Catalog();
        var reader = new Reader(catalog);

        // Act
        var exception = Record.Exception(() => reader.ReadString(json));

        // Assert
        Assert.NotNull(exception);
        Assert.IsType<Spdx3SerializationException>(exception);
    }
}