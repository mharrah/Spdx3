using Spdx3.Model.AI.Classes;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Software.Enums;

namespace Spdx3.Tests.Model.AI.Classes;

public class AiPackageTest : BaseModelTestClass
{
    [Fact]
    public void AiPackage_MinimalObject_Serializes()
    {
        // Arrange
        var supplier = new Person(TestCatalog, TestCreationInfo)
        {
            Name = "The supplier"
        };
        var aiPackage = new AiPackage(TestCatalog, TestCreationInfo, PredictableDateTime, supplier,
            new Uri("https://somewhere.com"), "1.0.0", SoftwarePurpose.executable);
        const string expected = """
                                {
                                  "releaseTime": "2025-02-22T01:23:45Z",
                                  "suppliedBy": "urn:Person:40f",
                                  "software_downloadLocation": "https://somewhere.com/",
                                  "software_packageVersion": "1.0.0",
                                  "software_primaryPurpose": "executable",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "ai_AiPackage",
                                  "spdxId": "urn:AiPackage:41c"
                                }
                                """;

        // Act
        var json = ToJson(aiPackage);

        // Assert
        Assert.Equal(expected, json);
    }
}