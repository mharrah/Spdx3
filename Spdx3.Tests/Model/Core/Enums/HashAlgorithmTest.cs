using System.Text.Json;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Enums;

public class HashAlgorithmTest
{
    [Fact]
    public void HashAlgorithm_HasCorrect_Count()
    {
        Assert.Equal(22, Enum.GetValues(typeof(HashAlgorithm)).Length);
    }

    [Fact]
    public void HashAlgorithm_Single_SerializesAsString()
    {
        // Arrange
        const HashAlgorithm enumVal = HashAlgorithm.blake3;

        // Act
        var json = JsonSerializer.Serialize<object>(Convert.ChangeType(enumVal, typeof(object)));

        // Assert
        Assert.Equal("\"blake3\"", json);
    }

    [Fact]
    public void HashAlgorithm_Array_SerializesAsStrings()
    {
        // Arrange
        var enumArray = new[]
        {
            HashAlgorithm.adler32,
            HashAlgorithm.blake2b256,
            HashAlgorithm.blake2b384,
            HashAlgorithm.blake2b512,
            HashAlgorithm.blake3,
            HashAlgorithm.crystalsDilithium,
            HashAlgorithm.crystalsKyber,
            HashAlgorithm.falcon,
            HashAlgorithm.md2,
            HashAlgorithm.md4,
            HashAlgorithm.md5,
            HashAlgorithm.md6,
            HashAlgorithm.other,
            HashAlgorithm.sha1,
            HashAlgorithm.sha224,
            HashAlgorithm.sha256,
            HashAlgorithm.sha384,
            HashAlgorithm.sha3_224,
            HashAlgorithm.sha3_256,
            HashAlgorithm.sha3_384,
            HashAlgorithm.sha3_512,
            HashAlgorithm.sha512
        };

        // Act
        var json = JsonSerializer.Serialize<object>(enumArray);

        const string expected = """
                                ["adler32","blake2b256","blake2b384","blake2b512","blake3","crystalsDilithium","crystalsKyber","falcon","md2","md4","md5","md6","other","sha1","sha224","sha256","sha384","sha3_224","sha3_256","sha3_384","sha3_512","sha512"]
                                """;

        // Assert
        Assert.Equal(expected, json);
    }
}