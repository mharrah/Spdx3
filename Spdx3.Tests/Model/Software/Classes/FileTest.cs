using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;
using File = Spdx3.Model.Software.Classes.File;

namespace Spdx3.Tests.Model.Software.Classes;

public class FileTest : BaseModelTestClass
{
    [Fact]
    public void File_MinimalObject_SerializesCorrectly()
    {
        // Arrange
        var file = new File(TestCatalog, TestCreationInfo, "filename");

        const string expected = """
                                {
                                  "name": "filename",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "software_File",
                                  "spdxId": "urn:File:402"
                                }
                                """;

        // Act
        var json = ToJson(file);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void File_FullyPopulated_SerializesCorrectly()
    {
        // Arrange
        var file = new File(TestCatalog, TestCreationInfo, "filename")
        {
            Comment = "Some comment",
            Description = "Some description",
            Name = "Some name",
            Summary = "Some summary",
            BuiltTime = PredictableDateTime,
            CopyrightText = "Some copyright text",
            PrimaryPurpose = SoftwarePurpose.application,
            ReleaseTime = PredictableDateTime,
            StandardName = "Some standard name",
            ValidUntilTime = PredictableDateTime,
            SuppliedBy = new Agent(TestCatalog, TestCreationInfo)
        };
        file.SupportLevel.Add(SupportType.noAssertion);
        file.VerifiedUsing.Add(new TestIntegrityMethod(TestCatalog));
        file.AdditionalPurpose.Add(SoftwarePurpose.archive);
        file.OriginatedBy.Add(new Agent(TestCatalog, TestCreationInfo));
        file.ContentIdentifier.Add(new ContentIdentifier(TestCatalog, ContentIdentifierType.gitoid,
            "some gitoid value"));
        file.AttributionText.Add("Some attribution text");
        file.AdditionalPurpose.Add(SoftwarePurpose.other);
        file.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.bower));
        file.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog, ExternalIdentifierType.cpe23,
            "cpe23 identifier"));
        file.Extension.Add(new TestExtension(TestCatalog));

        const string expected = """
                                {
                                  "name": "Some name",
                                  "additionalPurpose": [
                                    "archive",
                                    "other"
                                  ],
                                  "contentIdentifier": [
                                    "urn:ContentIdentifier:436"
                                  ],
                                  "primaryPurpose": "application",
                                  "attributionText": [
                                    "Some attribution text"
                                  ],
                                  "builtTime": "2025-02-22T01:23:45Z",
                                  "originatedBy": [
                                    "urn:Agent:429"
                                  ],
                                  "releaseTime": "2025-02-22T01:23:45Z",
                                  "standardName": "Some standard name",
                                  "suppliedBy": "urn:Agent:40f",
                                  "supportLevel": [
                                    "noAssertion"
                                  ],
                                  "validUntilTime": "2025-02-22T01:23:45Z",
                                  "comment": "Some comment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "Some description",
                                  "extension": [
                                    "urn:TestExtension:45d"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:450"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:443"
                                  ],
                                  "summary": "Some summary",
                                  "verifiedUsing": [
                                    "urn:TestIntegrityMethod:41c"
                                  ],
                                  "type": "software_File",
                                  "spdxId": "urn:File:402"
                                }
                                """;

        // Act
        var json = ToJson(file);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void File_NoName_InConstructor_Throws()
    {
        // Arrange
        string? nullObject = null;

        // Act
        var exception = Record.Exception(() =>
#pragma warning disable CS8604 // Possible null reference argument.
                new File(TestCatalog, TestCreationInfo, nullObject)
#pragma warning restore CS8604 // Possible null reference argument.
        );

        // Assert
        Assert.NotNull(exception);
    }


    [Fact]
    public void File_NoName_InSetter_Throws()
    {
        // Arrange
        string? nullObject = null;
        var file = new File(TestCatalog, TestCreationInfo, "filename");

        // Act
        var exception = Record.Exception(() =>
#pragma warning disable CS8601 // Possible null reference assignment.
                file.Name = nullObject
#pragma warning restore CS8601 // Possible null reference assignment.
        );

        // Assert
        Assert.NotNull(exception);
    }
}