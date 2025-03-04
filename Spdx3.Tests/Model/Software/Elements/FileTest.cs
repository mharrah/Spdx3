using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;
using Spdx3.Model.Software.Elements;
using Spdx3.Model.Software.Enums;
using Spdx3.Tests.Model.Core.NonElements;
using Spdx3.Tests.Model.Extension;
using File = Spdx3.Model.Software.Elements.File;

namespace Spdx3.Tests.Model.Software.Elements;

public class FileTest : BaseModelTestClass
{
    [Fact]
    public void File_MinimalObject_SerializesCorrectly()
    {
        // Arrange
        var file = new File(TestSpdxIdFactory, TestCreationInfo, "filename");       

        const string expected = """
                                {
                                  "name": "filename",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "software_File",
                                  "spdxId": "urn:File:402"
                                }
                                """;

        // Act
        var json = file.ToJson();
        
        // Assert
        Assert.Equal(expected, json);
        
    }

    [Fact]
    public void File_FullyPopulated_SerializesCorrectly()
    {
        // Arrange
        var file = new File(TestSpdxIdFactory, TestCreationInfo, "filename")       
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
            SuppliedBy = new Agent(TestSpdxIdFactory, TestCreationInfo)
        };
        file.SupportLevel.Add(SupportType.noAssertion);
        file.VerifiedUsing.Add(new TestIntegrityMethod(TestSpdxIdFactory));
        file.AdditionalPurpose.Add(SoftwarePurpose.archive);
        file.OriginatedBy.Add(new Agent(TestSpdxIdFactory, TestCreationInfo));
        file.ContentIdentifier.Add(new ContentIdentifier(TestSpdxIdFactory, ContentIdentifierType.gitoid, "some gitoid value"));
        file.AttributionText.Add("Some attribution text");
        file.AdditionalPurpose.Add(SoftwarePurpose.other);
        file.ExternalRef.Add(new ExternalRef(TestSpdxIdFactory, ExternalRefType.bower));
        file.ExternalIdentifier.Add(new ExternalIdentifier(TestSpdxIdFactory, ExternalIdentifierType.cpe23, "cpe23 identifier"));
        file.Extension.Add(new TestExtension(TestSpdxIdFactory));

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
        var json = file.ToJson();
        
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
            new File(TestSpdxIdFactory, TestCreationInfo, nullObject)
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
        var file = new File(TestSpdxIdFactory, TestCreationInfo, "filename");
        
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