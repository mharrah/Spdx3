using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.NonElements;

public class ExternalIdentifierTest : BaseSpdxClassTestClass
{
    [Fact]
    public void ExternalIdentifier_Basics()
    {
        // Arrange
        var factory = new SpdxClassFactory();

        // Act
        var externalIdentifier = factory.New<ExternalIdentifier>();

        // Assert
        Assert.NotNull(externalIdentifier);
        Assert.IsType<ExternalIdentifier>(externalIdentifier);
        Assert.Equal("ExternalIdentifier", externalIdentifier.Type);
        Assert.Equal("urn:ExternalIdentifier:3f5", externalIdentifier.SpdxId);
    }

    [Fact]
    public void ExternalIdentifier_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var externalIdentifier = TestFactory.New<ExternalIdentifier>();

        var expected = """
                       {
                         "type": "ExternalIdentifier",
                         "spdxId": "urn:ExternalIdentifier:3f5"
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
        var externalIdentifier = TestFactory.New<ExternalIdentifier>();
        externalIdentifier.Comment = "Test comment";
        externalIdentifier.IdentifierLocator.Add("testref");
        externalIdentifier.ExternalIdentifierType = ExternalIdentifierType.gitoid;
        externalIdentifier.IssuingAuthority = "testRef";
        externalIdentifier.Identifier = "TestIdentity";

        var expected = """
                       {
                         "comment": "Test comment",
                         "externalIdentifierType": "gitoid",
                         "identifier": "TestIdentity",
                         "identifierLocator": [
                           "testref"
                         ],
                         "issuingAuthority": "testRef",
                         "type": "ExternalIdentifier",
                         "spdxId": "urn:ExternalIdentifier:3f5"
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
        var externalIdentifier = TestFactory.New<ExternalIdentifier>();
        externalIdentifier.Comment = "Test comment";
        externalIdentifier.IdentifierLocator.Add("testref");
        externalIdentifier.ExternalIdentifierType = ExternalIdentifierType.gitoid;
        externalIdentifier.IssuingAuthority = "testRef";
        externalIdentifier.Identifier = null;

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
        var externalIdentifier = TestFactory.New<ExternalIdentifier>();
        externalIdentifier.Comment = "Test comment";
        externalIdentifier.IdentifierLocator.Add("testref");
        externalIdentifier.ExternalIdentifierType = ExternalIdentifierType.gitoid;
        externalIdentifier.IssuingAuthority = "testRef";
        externalIdentifier.Identifier = "";

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
        var externalIdentifier = TestFactory.New<ExternalIdentifier>();
        externalIdentifier.Comment = "Test comment";
        externalIdentifier.IdentifierLocator.Add("testref");
        externalIdentifier.ExternalIdentifierType = null;
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