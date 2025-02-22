using Spdx3.Model.Software.Elements;
using Spdx3.Model.Software.Enums;
using Spdx3.Tests.Model;

namespace Spdx3.Tests.SpxdModel.Software.Elements;

public class SoftwarePackageTest : BaseElementTestClass
{
    [Fact]
    public void SoftwarePackage_HasCorrectType()
    {
        var package = new SoftwarePackage(TestIdFactory, TestCreationInfo);
        Assert.NotNull(package);
        Assert.Equal("software_Package", package.Type);
    }

    [Fact]
    public void SoftwarePackage_ConstructorGeneratesId()
    {
        var package = new SoftwarePackage(TestIdFactory, TestCreationInfo);
        Assert.NotNull(package);
        Assert.Equal("urn:software_Package:testRef", package.SpdxId.ToString());
    }



    [Fact]
    public void SoftwarePackage_IsSerializableToJson()
    {
        var package = new SoftwarePackage(TestIdFactory, TestCreationInfo);
        package.Name = "Test Package";
        package.PrimaryPurpose = SoftwarePurpose.application;
        package.PackageVersion = "1.2.3";
        package.DownloadLocation = "https://example.com/download";
        package.AdditionalPurpose.Add(SoftwarePurpose.other);
        var actualJson = package.ToJson();
        string expected = """
                          {
                            "packageVersion": "1.2.3",
                            "downloadLocation": "https://example.com/download",
                            "additionalPurpose": [
                              "other"
                            ],
                            "primaryPurpose": "application",
                            "creationInfo": "urn:CreationInfo:testRef",
                            "name": "Test Package",
                            "type": "software_Package",
                            "spdxId": "urn:software_Package:testRef"
                          }
                          """;
        Assert.Equal(expected, actualJson);
    }
}