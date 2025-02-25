using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;

namespace Spdx3.Tests.Model.Core.NonElements;

public class PackageVerificationCodeTest : BaseSpdxClassTestClass
{
    [Fact]
    public void PackageVerificationCode_Basics()
    {
        // Act
        var hash = TestFactory.New<PackageVerificationCode>();

        // Assert
        Assert.NotNull(hash);
        Assert.IsType<PackageVerificationCode>(hash);
        Assert.Equal("PackageVerificationCode", hash.Type);
        Assert.Equal("urn:PackageVerificationCode:3f5", hash.SpdxId);
    }

    [Fact]
    public void PackageVerificationCode_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var hash = TestFactory.New<PackageVerificationCode>();
        hash.Algorithm = HashAlgorithm.falcon;
        hash.HashValue = "TestHashValue";
        const string expected = """
                                {
                                  "algorithm": "falcon",
                                  "hashValue": "TestHashValue",
                                  "type": "PackageVerificationCode",
                                  "spdxId": "urn:PackageVerificationCode:3f5"
                                }
                                """;

        // Act
        var json = hash.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void PackageVerificationCode_FullyPopulated_SerializesAsExpected()
    {
        // Arrange
        var hash = TestFactory.New<PackageVerificationCode>();
        hash.Algorithm = HashAlgorithm.falcon;
        hash.HashValue = "TestHashValue";
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
                                  "spdxId": "urn:PackageVerificationCode:3f5"
                                }
                                """;

        // Act
        var json = hash.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }


    [Fact]
    public void PackageVerificationCode_FailsValidation_WhenMissing_Algorithm()
    {
        // Arrange
        var hash = TestFactory.New<PackageVerificationCode>();
        hash.Algorithm = null;
        hash.HashValue = "TestHashValue";

        //  Act
        var exception = Record.Exception(() => hash.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object PackageVerificationCode, property Algorithm: Field is required", exception.Message);
    }

    [Fact]
    public void PackageVerificationCode_FailsValidation_WhenMissing_HashValue()
    {
        // Arrange
        var hash = TestFactory.New<PackageVerificationCode>();
        hash.Algorithm = HashAlgorithm.falcon;
        hash.HashValue = null;

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
        var hash = TestFactory.New<PackageVerificationCode>();
        hash.Algorithm = HashAlgorithm.md5;
        hash.HashValue = "";

        //  Act
        var exception = Record.Exception(() => hash.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object PackageVerificationCode, property HashValue: Field is empty", exception.Message);
    }
}