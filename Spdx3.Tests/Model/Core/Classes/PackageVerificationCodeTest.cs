using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Classes;

public class PackageVerificationCodeTest : BaseModelTestClass
{
    [Fact]
    public void PackageVerificationCode_Basics()
    {
        // Act
        var hash = new PackageVerificationCode(TestCatalog, HashAlgorithm.falcon, "TestHashValue");

        // Assert
        Assert.NotNull(hash);
        Assert.IsType<PackageVerificationCode>(hash);
        Assert.Equal("PackageVerificationCode", hash.Type);
        Assert.Equal("urn:PackageVerificationCode:40f", hash.SpdxId);
    }

    [Fact]
    public void PackageVerificationCode_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var hash = new PackageVerificationCode(TestCatalog, HashAlgorithm.falcon, "TestHashValue")
        {
            Algorithm = HashAlgorithm.falcon,
            HashValue = "TestHashValue"
        };
        const string expected = """
                                {
                                  "algorithm": "falcon",
                                  "hashValue": "TestHashValue",
                                  "type": "PackageVerificationCode",
                                  "spdxId": "urn:PackageVerificationCode:40f"
                                }
                                """;

        // Act
        var json = ToJson(hash);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void PackageVerificationCode_FullyPopulated_SerializesAsExpected()
    {
        // Arrange
        var hash = new PackageVerificationCode(TestCatalog, HashAlgorithm.falcon, "TestHashValue")
        {
            Algorithm = HashAlgorithm.falcon,
            HashValue = "TestHashValue"
        };
        hash.PackageVerificationCodeExcludedFile.Add("file1");
        hash.PackageVerificationCodeExcludedFile.Add("file2");
        const string expected = """
                                {
                                  "algorithm": "falcon",
                                  "hashValue": "TestHashValue",
                                  "packageVerificationCodeExcludedFile": [
                                    "file1",
                                    "file2"
                                  ],
                                  "type": "PackageVerificationCode",
                                  "spdxId": "urn:PackageVerificationCode:40f"
                                }
                                """;

        // Act
        var json = ToJson(hash);

        // Assert
        Assert.Equal(expected, json);
    }


    [Fact]
    public void PackageVerificationCode_FailsValidation_WhenMissing_HashValue()
    {
        // Arrange
        var hash = new PackageVerificationCode(TestCatalog, HashAlgorithm.falcon, "TestHashValue")
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
        Assert.Equal("Object PackageVerificationCode, property HashValue: Field is required", exception.Message);
    }

    [Fact]
    public void PackageVerificationCode_FailsValidation_WhenEmpty_HashValue()
    {
        // Arrange
        var hash = new PackageVerificationCode(TestCatalog, HashAlgorithm.falcon, "TestHashValue")
        {
            Algorithm = HashAlgorithm.md5,
            HashValue = ""
        };

        //  Act
        var exception = Record.Exception(() => hash.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object PackageVerificationCode, property HashValue: String field is empty", exception.Message);
    }
}