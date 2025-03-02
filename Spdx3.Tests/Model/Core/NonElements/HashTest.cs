using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;

namespace Spdx3.Tests.Model.Core.NonElements;

public class HashTest : BaseModelTestClass
{
    [Fact]
    public void Hash_Basics()
    {
        // Act
        var hash = new Hash(TestSpdxIdFactory, HashAlgorithm.falcon, "TestHashValue");

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
        var hash = new Hash(TestSpdxIdFactory, HashAlgorithm.falcon, "TestHashValue")
        {
            Algorithm = HashAlgorithm.falcon,
            HashValue = "TestHashValue"
        };
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
    public void Hash_FailsValidation_WhenMissing_HashValue()
    {
        // Arrange
        var hash = new Hash(TestSpdxIdFactory, HashAlgorithm.falcon, "TestHashValue")
        {
            Algorithm = HashAlgorithm.falcon
        };
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        hash.HashValue = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

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
        var hash = new Hash(TestSpdxIdFactory, HashAlgorithm.falcon, "TestHashValue")
        {
            Algorithm = HashAlgorithm.md5,
            HashValue = ""
        };

        //  Act
        var exception = Record.Exception(() => hash.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object Hash, property HashValue: Field is empty", exception.Message);
    }
}