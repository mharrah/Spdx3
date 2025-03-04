using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;
using Spdx3.Model.Software.Elements;
using Spdx3.Model.Software.Enums;
using Spdx3.Tests.Model.Core.NonElements;
using Spdx3.Tests.Model.Extension;
using File = Spdx3.Model.Software.Elements.File;

namespace Spdx3.Tests.Model.Software.Elements;

public class SnippetTest : BaseModelTestClass
{
    [Fact]
    public void Snippet_MinimalObject_SerializesCorrectly()
    {
        // Arrange
        var file = new File(TestSpdxIdFactory, TestCreationInfo, "filename");
        var snippet = new Snippet(TestSpdxIdFactory, TestCreationInfo, file);
        const string expected = """
                                {
                                  "snippetFromFile": "urn:File:402",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "software_Snippet",
                                  "spdxId": "urn:Snippet:40f"
                                }
                                """;

        // Act
        var json = snippet.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
    
    [Fact]
    public void Snippet_FullyPopulated_SerializesCorrectly()
    {
        // Arrange
        var file = new File(TestSpdxIdFactory, TestCreationInfo, "filename");
        var snippet = new Snippet(TestSpdxIdFactory, TestCreationInfo, file)
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
            ByteRange = new PositiveIntegerRange(TestSpdxIdFactory,1, 5),
            LineRange = new PositiveIntegerRange(TestSpdxIdFactory,7, 15),
        };
        snippet.SupportLevel.Add(SupportType.noAssertion);
        snippet.VerifiedUsing.Add(new TestIntegrityMethod(TestSpdxIdFactory));
        snippet.AdditionalPurpose.Add(SoftwarePurpose.archive);
        snippet.OriginatedBy.Add(new Agent(TestSpdxIdFactory, TestCreationInfo));
        snippet.ContentIdentifier.Add(new ContentIdentifier(TestSpdxIdFactory, ContentIdentifierType.gitoid, "some gitoid value"));
        snippet.AttributionText.Add("Some attribution text");
        snippet.AdditionalPurpose.Add(SoftwarePurpose.other);
        snippet.ExternalRef.Add(new ExternalRef(TestSpdxIdFactory, ExternalRefType.bower));
        snippet.ExternalIdentifier.Add(new ExternalIdentifier(TestSpdxIdFactory, ExternalIdentifierType.cpe23, "cpe23 identifier"));
        snippet.Extension.Add(new TestExtension(TestSpdxIdFactory));

        
        const string expected = """
                                {
                                  "byteRange": "urn:PositiveIntegerRange:41c",
                                  "lineRange": "urn:PositiveIntegerRange:429",
                                  "snippetFromFile": "urn:File:402",
                                  "additionalPurpose": [
                                    "archive",
                                    "other"
                                  ],
                                  "contentIdentifier": [
                                    "urn:ContentIdentifier:450"
                                  ],
                                  "attributionText": [
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
        var json = snippet.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
    
}