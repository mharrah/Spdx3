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
        var anyLicenseInfo = new TestAnyLicenseInfo(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "simplelicensing_TestAnyLicenseInfo",
                                  "spdxId": "urn:TestAnyLicenseInfo:40f"
                                }
                                """;

        // Act
        var json = ToJson(anyLicenseInfo);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_AnyLicenseInfo_SerializesProperly()
    {
        // Arrange
        var anyLicenseInfo = new TestAnyLicenseInfo(TestCatalog, TestCreationInfo)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary"
        };
        anyLicenseInfo.Extension.Add(new TestExtension(TestCatalog));
        anyLicenseInfo.ExternalIdentifier.Add(
            new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));
        anyLicenseInfo.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.altDownloadLocation));
        anyLicenseInfo.VerifiedUsing.Add(new TestIntegrityMethod(TestCatalog));


        const string expected = """
                                {
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "extension": [
                                    "urn:TestExtension:41c"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:429"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:436"
                                  ],
                                  "name": "TestName",
                                  "summary": "TestSummary",
                                  "verifiedUsing": [
                                    "urn:TestIntegrityMethod:443"
                                  ],
                                  "type": "simplelicensing_TestAnyLicenseInfo",
                                  "spdxId": "urn:TestAnyLicenseInfo:40f"
                                }
                                """;

        // Act
        var json = ToJson(anyLicenseInfo);

        // Assert
        Assert.Equal(expected, json);
    }
}