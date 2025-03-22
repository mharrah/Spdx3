using Spdx3.Exceptions;
using Spdx3.Model.Dataset.Classes;
using Spdx3.Model.Dataset.Enums;

namespace Spdx3.Tests.Model.Dataset.Classes;

public class DatasetPackageTest : BaseModelTest
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

    [Fact]
    public void DatasetPackage_ThrowsWhen_DatasetSize_LessThanZero()
    {
        // Arrange
        var datasetPackage = new DatasetPackage(TestCatalog, TestCreationInfo, [DatasetType.audio]);

        // Act and Assert
        Assert.Throws<Spdx3Exception>(() => datasetPackage.DatasetSize = -1);
    }
    
    
    [Fact]
    public void DatasetPackage_AllowsSetting_DatasetSize_Null()
    {
        // Arrange
        var datasetPackage = new DatasetPackage(TestCatalog, TestCreationInfo, [DatasetType.audio]);

        // Act and Assert
        Assert.Null(datasetPackage.DatasetSize);
        
        datasetPackage.DatasetSize = 1;
        Assert.NotNull(datasetPackage.DatasetSize);
        
        datasetPackage.DatasetSize = null;
        Assert.Null(datasetPackage.DatasetSize);
    }
}