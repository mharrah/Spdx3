using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;

namespace Spdx3.Tests.Model.Core.NonElements;

public class HashTest : BaseModelTestClass
{
    [Fact]
    public void Hash_Basics()
    {
        // Act
        var hash = TestFactory.New<Hash>();

        // Assert
        Assert.NotNull(hash);
        Assert.IsType<Hash>(hash);
        Assert.Equal("Hash", hash.Type);
        Assert.Equal("urn:Hash:402", hash.SpdxId);
    }

    [Fact]
    public void Hash_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var hash = TestFactory.New<Hash>();
        hash.Algorithm = HashAlgorithm.falcon;
        hash.HashValue = "TestHashValue";
        const string expected = """
                                {
                                  "algorithm": "falcon",
                                  "hashValue": "TestHashValue",
                                  "type": "Hash",
                                  "spdxId": "urn:Hash:402"
                                }
                                """;

        // Act
        var json = hash.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void Hash_FailsValidation_WhenMissing_Algorithm()
    {
        // Arrange
        var hash = TestFactory.New<Hash>();
        hash.Algorithm = null;
        hash.HashValue = "TestHashValue";

        //  Act
        var exception = Record.Exception(() => hash.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object Hash, property Algorithm: Field is required", exception.Message);
    }


    [Fact]
    public void Hash_FailsValidation_WhenMissing_HashValue()
    {
        // Arrange
        var hash = TestFactory.New<Hash>();
        hash.Algorithm = HashAlgorithm.falcon;
        hash.HashValue = null;

        //  Act
        var exception = Record.Exception(() => hash.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object Hash, property HashValue: Field is required", exception.Message);
    }

    [Fact]
    public void Hash_FailsValidation_WhenEmpty_HashValue()
    {
        // Arrange
        var hash = TestFactory.New<Hash>();
        hash.Algorithm = HashAlgorithm.md5;
        hash.HashValue = "";

        //  Act
        var exception = Record.Exception(() => hash.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object Hash, property HashValue: Field is empty", exception.Message);
    }
}