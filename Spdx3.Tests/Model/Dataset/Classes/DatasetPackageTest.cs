using Spdx3.Model.Dataset.Classes;
using Spdx3.Model.Dataset.Enums;

namespace Spdx3.Tests.Model.Dataset.Classes;

public class DatasetPackageTest : BaseModelTestClass
{
    [Fact]
    public void DatasetPackage_MinimalObject_Serializes()
    {
        // Arrange
        var datasetPackage = new DatasetPackage(TestCatalog, TestCreationInfo, [DatasetType.audio]);
        const string expected = """
                                {
                                  "dataset_datasetType": [
                                    "audio"
                                  ],
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "dataset_DatasetPackage",
                                  "spdxId": "urn:DatasetPackage:40f"
                                }
                                """;

        // Act
        var json = ToJson(datasetPackage);

        // Assert
        Assert.Equal(expected, json);
    }
}