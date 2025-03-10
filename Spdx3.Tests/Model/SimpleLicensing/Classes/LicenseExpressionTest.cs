using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.SimpleLicensing.Classes;

public class LicenseExpressionTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_LicenseExpression_SerializesProperly()
    {
        // Arrange
        var licenseExpression = new LicenseExpression(TestSpdxIdFactory, TestCreationInfo, "MIT");
        const string expected = """
                                {
                                  "licenseExpression": "MIT",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "simplelicensing_LicenseExpression",
                                  "spdxId": "urn:LicenseExpression:402"
                                }
                                """;

        // Act
        var json = licenseExpression.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_LicenseExpression_SerializesProperly()
    {
        // Arrange
        var licenseExpression = new LicenseExpression(TestSpdxIdFactory, TestCreationInfo, "MIT")
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            LicenseListVersion = "1.0.0",
            CustomIdToUri = new DictionaryEntry(TestSpdxIdFactory, "some key", "some value")
        };
        licenseExpression.Extension.Add(new TestExtension(TestSpdxIdFactory));
        licenseExpression.ExternalIdentifier.Add(
            new ExternalIdentifier(TestSpdxIdFactory, ExternalIdentifierType.email, "example@example.com"));
        licenseExpression.ExternalRef.Add(new ExternalRef(TestSpdxIdFactory, ExternalRefType.altDownloadLocation));
        licenseExpression.VerifiedUsing.Add(new TestIntegrityMethod(TestSpdxIdFactory));
        const string expected = """
                                {
                                  "licenseExpression": "MIT",
                                  "customIdToUri": "urn:DictionaryEntry:40f",
                                  "licenseListVersion": "1.0.0",
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
                                  "verifiedUsing": [
                                    "urn:TestIntegrityMethod:443"
                                  ],
                                  "type": "simplelicensing_LicenseExpression",
                                  "spdxId": "urn:LicenseExpression:402"
                                }
                                """;

        // Act
        var json = licenseExpression.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}