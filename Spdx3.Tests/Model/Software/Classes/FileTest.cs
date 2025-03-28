using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;
using Spdx3.Utility;
using File = Spdx3.Model.Software.Classes.File;

namespace Spdx3.Tests.Model.Software.Classes;

public class FileTest : BaseModelTest
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
                                  "spdxId": "urn:File:40f"
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
        file.SupportLevel.Add(SupportType.deployed);
        file.SupportLevel.Add(SupportType.support);
        file.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));
        file.AdditionalPurpose.Add(SoftwarePurpose.archive);
        file.OriginatedBy.Add(new Agent(TestCatalog, TestCreationInfo));
        file.ContentIdentifier.Add(new ContentIdentifier(TestCatalog, ContentIdentifierType.gitoid,
            new Uri("urn:some-gitoid-value")));
        file.AttributionText.Add("Some attribution text");
        file.AdditionalPurpose.Add(SoftwarePurpose.other);
        file.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.bower));
        file.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog, ExternalIdentifierType.cpe23,
            "cpe23 identifier"));
        file.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));

        const string expected = """
                                {
                                  "name": "Some name",
                                  "software_additionalPurpose": [
                                    "archive",
                                    "other"
                                  ],
                                  "software_contentIdentifier": [
                                    "urn:ContentIdentifier:443"
                                  ],
                                  "software_primaryPurpose": "application",
                                  "software_attributionText": [
                                    "Some attribution text"
                                  ],
                                  "builtTime": "2025-02-22T01:23:45Z",
                                  "originatedBy": [
                                    "urn:Agent:436"
                                  ],
                                  "releaseTime": "2025-02-22T01:23:45Z",
                                  "standardName": "Some standard name",
                                  "suppliedBy": "urn:Agent:41c",
                                  "supportLevel": [
                                    "deployed",
                                    "support"
                                  ],
                                  "validUntilTime": "2025-02-22T01:23:45Z",
                                  "comment": "Some comment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "Some description",
                                  "extension": [
                                    "urn:ExtensionConcreteTestFixture:46a"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:45d"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:450"
                                  ],
                                  "summary": "Some summary",
                                  "verifiedUsing": [
                                    "urn:IntegrityMethodConcreteTestFixture:429"
                                  ],
                                  "type": "software_File",
                                  "spdxId": "urn:File:40f"
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
    
            
    [Fact]
    public void Validation_FailsWhen_Name_NullOrEmpty()
    {
        // Arrange
        var file = IncompleteObjectFactory.Create<File>();
        
        // Act and Assert
        Assert.Throws<Spdx3ValidationException>(() => file.Validate());
    }
    
}