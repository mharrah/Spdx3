using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.SimpleLicensing.Classes;

public class AnyLicenseInfoTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_AnyLicenseInfo_SerializesProperly()
    {
        // Arrange
        var anyLicenseInfo = new TestAnyLicenseInfo(TestSpdxIdFactory, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "simplelicensing_TestAnyLicenseInfo",
                                  "spdxId": "urn:TestAnyLicenseInfo:402"
                                }
                                """;

        // Act
        var json = anyLicenseInfo.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_AnyLicenseInfo_SerializesProperly()
    {
        // Arrange
        var anyLicenseInfo = new TestAnyLicenseInfo(TestSpdxIdFactory, TestCreationInfo)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary"
        };
        anyLicenseInfo.Extension.Add(new TestExtension(TestSpdxIdFactory));
        anyLicenseInfo.ExternalIdentifier.Add(
            new ExternalIdentifier(TestSpdxIdFactory, ExternalIdentifierType.email, "example@example.com"));
        anyLicenseInfo.ExternalRef.Add(new ExternalRef(TestSpdxIdFactory, ExternalRefType.altDownloadLocation));
        anyLicenseInfo.VerifiedUsing.Add(new TestIntegrityMethod(TestSpdxIdFactory));


        const string expected = """
                                {
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "extension": [
                                    "urn:TestExtension:40f"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:41c"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:429"
                                  ],
                                  "name": "TestName",
                                  "summary": "TestSummary",
                                  "verifiedUsing": [
                                    "urn:TestIntegrityMethod:436"
                                  ],
                                  "type": "simplelicensing_TestAnyLicenseInfo",
                                  "spdxId": "urn:TestAnyLicenseInfo:402"
                                }
                                """;

        // Act
        var json = anyLicenseInfo.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}