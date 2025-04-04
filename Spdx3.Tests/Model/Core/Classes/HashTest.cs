using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Classes;

public class HashTest : BaseModelTest
{
    [Fact]
    public void Hash_Basics()
    {
        // Act
        var hash = new Hash(TestCatalog, HashAlgorithm.falcon, "TestHashValue");

        // Assert
        Assert.NotNull(hash);
        Assert.IsType<Hash>(hash);
        Assert.Equal("Hash", hash.Type);
        Assert.Equal(new Uri("urn:Hash:40f"), hash.SpdxId);
    }

    [Fact]
    public void Hash_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var hash = new Hash(TestCatalog, HashAlgorithm.falcon, "TestHashValue")
        {
            Algorithm = HashAlgorithm.falcon,
            HashValue = "TestHashValue"
        };
        const string expected = """
                                {
                                  "algorithm": "falcon",
                                  "hashValue": "TestHashValue",
                                  "type": "Hash",
                                  "spdxId": "urn:Hash:40f"
                                }
                                """;

        // Act
        var json = ToJson(hash);

        // Assert
        Assert.Equal(expected, json);
    }


    [Fact]
    public void Hash_FailsValidation_WhenMissing_HashValue()
    {
        // Arrange
        var hash = new Hash(TestCatalog, HashAlgorithm.falcon, "TestHashValue")
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
        var hash = new Hash(TestCatalog, HashAlgorithm.falcon, "TestHashValue")
        {
            Algorithm = HashAlgorithm.md5,
            HashValue = ""
        };

        //  Act
        var exception = Record.Exception(() => hash.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object Hash, property HashValue: String field is empty", exception.Message);
    }
}