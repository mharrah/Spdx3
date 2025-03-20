using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Classes;

public class ExternalIdentifierTest : BaseModelTestClass
{
    [Fact]
    public void ExternalIdentifier_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var externalIdentifier =
            new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "email@example.com");

        const string expected = """
                                {
                                  "externalIdentifierType": "email",
                                  "identifier": "email@example.com",
                                  "type": "ExternalIdentifier",
                                  "spdxId": "urn:ExternalIdentifier:40f"
                                }
                                """;

        // Act
        var json = ToJson(externalIdentifier);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void ExternalIdentifier_FullyPopulated_SerializesAsExpected()
    {
        // Arrange
        var externalIdentifier =
            new ExternalIdentifier(TestCatalog, ExternalIdentifierType.gitoid, "TestIdentity")
            {
                Comment = "Test comment",
                IssuingAuthority = "testRef"
            };
        externalIdentifier.IdentifierLocator.Add("testref");

        const string expected = """
                                {
                                  "comment": "Test comment",
                                  "externalIdentifierType": "gitoid",
                                  "identifier": "TestIdentity",
                                  "identifierLocator": [
                                    "testref"
                                  ],
                                  "issuingAuthority": "testRef",
                                  "type": "ExternalIdentifier",
                                  "spdxId": "urn:ExternalIdentifier:40f"
                                }
                                """;

        // Act
        var json = ToJson(externalIdentifier);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void ExternalIdentifier_FailsValidation_WhenMissing_Identifier()
    {
        // Arrange
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        var externalIdentifier = new ExternalIdentifier(TestCatalog, ExternalIdentifierType.gitoid, null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        externalIdentifier.Comment = "Test comment";
        externalIdentifier.IdentifierLocator.Add("testref");
        externalIdentifier.IssuingAuthority = "testRef";

        //  Act
        var exception = Record.Exception(() => externalIdentifier.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object ExternalIdentifier, property Identifier: Field is required", exception.Message);
    }

    [Fact]
    public void ExternalIdentifier_FailsValidation_WhenEmpty_Identifier()
    {
        // Arrange
        var externalIdentifier = new ExternalIdentifier(TestCatalog, ExternalIdentifierType.gitoid, string.Empty)
        {
            Comment = "Test comment",
            IssuingAuthority = "testRef"
        };
        externalIdentifier.IdentifierLocator.Add("testref");

        //  Act
        var exception = Record.Exception(() => externalIdentifier.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object ExternalIdentifier, property Identifier: String field is empty", exception.Message);
    }
}