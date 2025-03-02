using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.NonElements;

namespace Spdx3.Tests.Model.Core.NonElements;

public class CreationInfoTest : BaseModelTestClass
{
    [Fact]
    public void CreationInfo_Basics()
    {
        // Arrange
        var creationInfo = new CreationInfo(TestSpdxIdFactory, PredictableDateTime);

        // Assert
        Assert.NotNull(creationInfo);
        Assert.IsType<CreationInfo>(creationInfo);
        Assert.Equal("CreationInfo", creationInfo.Type);
        Assert.Equal("urn:CreationInfo:402", creationInfo.SpdxId);
    }

    [Fact]
    public void CreationInfo_FullyPopulated_SerializesAsExpected()
    {
        // Arrange
        var creationInfo = new CreationInfo(TestSpdxIdFactory, PredictableDateTime)
        {
            Comment = "Test comment"
        };
        creationInfo.CreatedBy.Add(new Agent(TestSpdxIdFactory, creationInfo));
        creationInfo.CreatedUsing.Add(new Tool(TestSpdxIdFactory, creationInfo));
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
        var json = creationInfo.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }


    [Fact]
    public void CreationInfo_MinimallyPopulated_SerializesAsExpected()
    {
        // Act
        var creationInfo = new CreationInfo(TestSpdxIdFactory, PredictableDateTime);
        const string expected = """
                                {
                                  "created": "2025-02-22T01:23:45Z",
                                  "specVersion": "3.0.1",
                                  "type": "CreationInfo",
                                  "spdxId": "urn:CreationInfo:402"
                                }
                                """;

        // Assert - note that empty collections are not serialized at all
        var json = creationInfo.ToJson();
        Assert.Equal(expected, json);
    }
}