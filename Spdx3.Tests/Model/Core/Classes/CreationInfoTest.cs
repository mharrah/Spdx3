using Spdx3.Model.Core.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class CreationInfoTest : BaseModelTestClass
{
    [Fact]
    public void CreationInfo_Basics()
    {
        // Arrange
        var creationInfo = new CreationInfo(TestCatalog, PredictableDateTime);

        // Assert
        Assert.NotNull(creationInfo);
        Assert.IsType<CreationInfo>(creationInfo);
        Assert.Equal("CreationInfo", creationInfo.Type);
        Assert.Equal("urn:CreationInfo:402", creationInfo.SpdxId);
    }


    [Fact]
    public void CreationInfo_Constructor_WithoutPassingDateTime()
    {
        // Arrange
        var creationInfo = new CreationInfo(TestCatalog);

        // Assert
        Assert.NotNull(creationInfo);
        Assert.IsType<CreationInfo>(creationInfo);
        Assert.NotEqual(creationInfo.Created, PredictableDateTime);
        // Created in the past...
        Assert.True(DateTimeOffset.Now.CompareTo(creationInfo.Created) > 0);
        // but created less than 2 sec ago
        Assert.True(DateTimeOffset.Now.Add(new TimeSpan(0, 0, -2)).CompareTo(creationInfo.Created) < 0);
        Assert.Equal("CreationInfo", creationInfo.Type);
        Assert.Equal("urn:CreationInfo:402", creationInfo.SpdxId);
    }

    [Fact]
    public void CreationInfo_FullyPopulated_SerializesAsExpected()
    {
        // Arrange
        var creationInfo = new CreationInfo(TestCatalog, PredictableDateTime)
        {
            Comment = "Test comment"
        };
        creationInfo.CreatedBy.Add(new Agent(TestCatalog, creationInfo));
        creationInfo.CreatedUsing.Add(new Tool(TestCatalog, creationInfo));
        const string expected = """
                                {
                                  "createdBy": [
                                    "urn:Agent:40f"
                                  ],
                                  "comment": "Test comment",
                                  "created": "2025-02-22T01:23:45Z",
                                  "createdUsing": [
                                    "urn:Tool:41c"
                                  ],
                                  "specVersion": "3.0.1",
                                  "type": "CreationInfo",
                                  "spdxId": "urn:CreationInfo:402"
                                }
                                """;

        // Act
        var json = ToJson(creationInfo);

        // Assert
        Assert.Equal(expected, json);
    }


    [Fact]
    public void CreationInfo_MinimallyPopulated_SerializesAsExpected()
    {
        // Act
        var creationInfo = new CreationInfo(TestCatalog, PredictableDateTime);
        const string expected = """
                                {
                                  "created": "2025-02-22T01:23:45Z",
                                  "specVersion": "3.0.1",
                                  "type": "CreationInfo",
                                  "spdxId": "urn:CreationInfo:402"
                                }
                                """;

        // Assert - note that empty collections are not serialized at all
        var json = ToJson(creationInfo);
        Assert.Equal(expected, json);
    }

    [Fact]
    public void CreationInfo_DeserializesAsExpected()
    {
        const string json = """
                            {
                              "created": "2025-02-22T01:23:45Z",
                              "specVersion": "3.0.1",
                              "type": "CreationInfo",
                              "spdxId": "urn:CreationInfo:402"
                            }
                            """;
        
        var creationInfo = FromJson<CreationInfo>(json);
        Assert.NotNull(creationInfo);
        Assert.IsType<CreationInfo>(creationInfo);
        Assert.Equal("CreationInfo", creationInfo.Type);
        Assert.Equal("urn:CreationInfo:402", creationInfo.SpdxId);
        Assert.Equal("3.0.1", creationInfo.SpecVersion);
        Assert.Equal(PredictableDateTime, creationInfo.Created);
        
    }
}