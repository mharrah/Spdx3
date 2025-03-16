using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;
using File = Spdx3.Model.Software.Classes.File;

namespace Spdx3.Tests.Model.Software.Classes;

public class SnippetTest : BaseModelTestClass
{
    [Fact]
    public void Snippet_MinimalObject_SerializesCorrectly()
    {
        // Arrange
        var file = new File(TestCatalog, TestCreationInfo, "filename");
        var snippet = new Snippet(TestCatalog, TestCreationInfo, file);
        const string expected = """
                                {
                                  "software_snippetFromFile": "urn:File:402",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "software_Snippet",
                                  "spdxId": "urn:Snippet:40f"
                                }
                                """;

        // Act
        var json = ToJson(snippet);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void Snippet_FullyPopulated_SerializesCorrectly()
    {
        // Arrange
        var file = new File(TestCatalog, TestCreationInfo, "filename");
        var snippet = new Snippet(TestCatalog, TestCreationInfo, file)
        {
            Comment = "Some comment",
            Description = "Some description",
            Name = "Some name",
            Summary = "Some summary",
            BuiltTime = PredictableDateTime,
            CopyrightText = "Some copyright text",
            ReleaseTime = PredictableDateTime,
            StandardName = "Some standard name",
            ValidUntilTime = PredictableDateTime,
            ByteRange = new PositiveIntegerRange(TestCatalog, 1, 5),
            LineRange = new PositiveIntegerRange(TestCatalog, 7, 15)
        };
        snippet.SupportLevel.Add(SupportType.noAssertion);
        snippet.VerifiedUsing.Add(new TestIntegrityMethod(TestCatalog));
        snippet.AdditionalPurpose.Add(SoftwarePurpose.archive);
        snippet.OriginatedBy.Add(new Agent(TestCatalog, TestCreationInfo));
        snippet.ContentIdentifier.Add(new ContentIdentifier(TestCatalog, ContentIdentifierType.gitoid,
            "some gitoid value"));
        snippet.AttributionText.Add("Some attribution text");
        snippet.AdditionalPurpose.Add(SoftwarePurpose.other);
        snippet.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.bower));
        snippet.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog, ExternalIdentifierType.cpe23,
            "cpe23 identifier"));
        snippet.Extension.Add(new TestExtension(TestCatalog));


        const string expected = """
                                {
                                  "software_byteRange": "urn:PositiveIntegerRange:41c",
                                  "software_lineRange": "urn:PositiveIntegerRange:429",
                                  "software_snippetFromFile": "urn:File:402",
                                  "software_additionalPurpose": [
                                    "archive",
                                    "other"
                                  ],
                                  "software_contentIdentifier": [
                                    "urn:ContentIdentifier:450"
                                  ],
                                  "software_attributionText": [
                                    "Some attribution text"
                                  ],
                                  "builtTime": "2025-02-22T01:23:45Z",
                                  "originatedBy": [
                                    "urn:Agent:443"
                                  ],
                                  "releaseTime": "2025-02-22T01:23:45Z",
                                  "standardName": "Some standard name",
                                  "supportLevel": [
                                    "noAssertion"
                                  ],
                                  "validUntilTime": "2025-02-22T01:23:45Z",
                                  "comment": "Some comment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "Some description",
                                  "extension": [
                                    "urn:TestExtension:477"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:46a"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:45d"
                                  ],
                                  "name": "Some name",
                                  "summary": "Some summary",
                                  "verifiedUsing": [
                                    "urn:TestIntegrityMethod:436"
                                  ],
                                  "type": "software_Snippet",
                                  "spdxId": "urn:Snippet:40f"
                                }
                                """;

        // Act
        var json = ToJson(snippet);

        // Assert
        Assert.Equal(expected, json);
    }


    [Fact]
    public void Snippet_FailsValidation_WhenEmpty_File()
    {
        // Arrange
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        var snippet = new Snippet(TestCatalog, TestCreationInfo, null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

        // Act
        var ex = Record.Exception(() => ToJson(snippet));

        // Assert
        Assert.NotNull(ex);
        Assert.IsType<Spdx3ValidationException>(ex);
        Assert.Equal("Object Snippet, property SnippetFromFile: Cannot be null, empty, or whitespace.", ex.Message);
    }
}