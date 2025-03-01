using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.NonElements;

public class ExternalIdentifierTest : BaseModelTestClass
{
    [Fact]
    public void ExternalIdentifier_Requires_IdentifierType_And_Identifier()
    {
        // Arrange
        var factory = new SpdxClassFactory();

        // Act
        var exception = Record.Exception(() => factory.New<ExternalIdentifier>());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Creating instances of ExternalIdentifier requires using the " +
                     "New(ExternalIdentifierType externalIdentifierType, string identifier) form", exception.Message);
    }

    [Fact]
    public void ExternalIdentifier_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var externalIdentifier = TestFactory.New<ExternalIdentifier>(ExternalIdentifierType.email, "email@example.com");

        const string expected = """
                                {
                                  "externalIdentifierType": "email",
                                  "identifier": "email@example.com",
                                  "type": "ExternalIdentifier",
                                  "spdxId": "urn:ExternalIdentifier:402"
                                }
                                """;

        // Act
        var json = externalIdentifier.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void ExternalIdentifier_FullyPopulated_SerializesAsExpected()
    {
        // Arrange
        var externalIdentifier = TestFactory.New<ExternalIdentifier>(ExternalIdentifierType.gitoid, "TestIdentity");
        externalIdentifier.Comment = "Test comment";
        externalIdentifier.IdentifierLocator.Add("testref");
        externalIdentifier.IssuingAuthority = "testRef";

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
                                  "spdxId": "urn:ExternalIdentifier:402"
                                }
                                """;

        // Act
        var json = externalIdentifier.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void ExternalIdentifier_FailsValidation_WhenMissing_Identifier()
    {
        // Arrange
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        var externalIdentifier = TestFactory.New<ExternalIdentifier>(ExternalIdentifierType.gitoid, null);
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
        var externalIdentifier = TestFactory.New<ExternalIdentifier>(ExternalIdentifierType.gitoid, string.Empty);
        externalIdentifier.Comment = "Test comment";
        externalIdentifier.IdentifierLocator.Add("testref");
        externalIdentifier.IssuingAuthority = "testRef";

        //  Act
        var exception = Record.Exception(() => externalIdentifier.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object ExternalIdentifier, property Identifier: Field is empty", exception.Message);
    }


    [Fact]
    public void ExternalIdentifier_FailsValidation_WhenMissing_ExternalIdentifierType()
    {
        // Arrange
        var externalIdentifier = TestFactory.New<ExternalIdentifier>(ExternalIdentifierType.email, "Test identifier");
        externalIdentifier.Comment = "Test comment";
        externalIdentifier.ExternalIdentifierType = null; // This should break Validation
        externalIdentifier.IssuingAuthority = "Test Authority";
        externalIdentifier.Identifier = "Test identifier";

        //  Act
        var exception = Record.Exception(() => externalIdentifier.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object ExternalIdentifier, property ExternalIdentifierType: Field is required",
            exception.Message);
    }
}