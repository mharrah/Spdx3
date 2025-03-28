using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class ArtifactTest : BaseModelTest
{
    [Fact]
    public void BrandNew_Artifact_HasRequiredFields()
    {
        // Arrange
        var element = new ArtifactConcreteTestFixture(TestCatalog, TestCreationInfo);

        // Assert
        Assert.Null(Record.Exception(() => element.Validate()));
        Assert.Equal("ArtifactConcreteTestFixture", element.Type);
    }

    [Fact]
    public void BrandNew_Artifact_SerializesProperly()
    {
        // Arrange
        var element = new ArtifactConcreteTestFixture(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "ArtifactConcreteTestFixture",
                                  "spdxId": "urn:ArtifactConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(element);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Artifact_SerializesProperly()
    {
        // Arrange
        var element = new ArtifactConcreteTestFixture(TestCatalog, TestCreationInfo)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary",
            SupportLevel = [SupportType.support, SupportType.deployed, SupportType.limitedSupport],
            SuppliedBy = new Agent(TestCatalog, TestCreationInfo),
            BuiltTime = PredictableDateTime.AddDays(1),
            ReleaseTime           = PredictableDateTime.AddDays(2),
            ValidUntilTime = PredictableDateTime.AddDays(3),
            StandardName = "TestStandardName" 
        };
        element.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        element.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));
        element.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.other));
        element.OriginatedBy.Add(new Agent(TestCatalog, TestCreationInfo));
        element.OriginatedBy.Add(new Agent(TestCatalog, TestCreationInfo));
        element.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));

        const string expected = """
                                {
                                  "builtTime": "2025-02-23T01:23:45Z",
                                  "originatedBy": [
                                    "urn:Agent:450",
                                    "urn:Agent:45d"
                                  ],
                                  "releaseTime": "2025-02-24T01:23:45Z",
                                  "standardName": "TestStandardName",
                                  "suppliedBy": "urn:Agent:41c",
                                  "supportLevel": [
                                    "support",
                                    "deployed",
                                    "limitedSupport"
                                  ],
                                  "validUntilTime": "2025-02-25T01:23:45Z",
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "extension": [
                                    "urn:ExtensionConcreteTestFixture:429"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:436"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:443"
                                  ],
                                  "name": "TestName",
                                  "summary": "TestSummary",
                                  "verifiedUsing": [
                                    "urn:IntegrityMethodConcreteTestFixture:46a"
                                  ],
                                  "type": "ArtifactConcreteTestFixture",
                                  "spdxId": "urn:ArtifactConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(element);

        // Assert
        Assert.Equal(expected, json);
    }

    
    [Fact]
    public void TypeNew_Artifact_FailsValidation_Empty_Type()
    {
        // Arrange
        var element = new ArtifactConcreteTestFixture(TestCatalog, TestCreationInfo)
        {
            Type = string.Empty
        };

        // Act
        var exception = Record.Exception(() => element.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object ArtifactConcreteTestFixture, property Type: String field is empty", exception.Message);
    }
}