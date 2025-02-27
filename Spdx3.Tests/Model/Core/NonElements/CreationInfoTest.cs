using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.NonElements;
using Spdx3.Tests.Model.Core.Elements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.NonElements;

public class CreationInfoTest : BaseModelTestClass
{
    [Fact]
    public void CreationInfo_Basics()
    {
        // Arrange
        var factory = new SpdxClassFactory();

        // Act
        var creationInfo = factory.New<CreationInfo>();

        // Assert
        Assert.NotNull(creationInfo);
        Assert.IsType<CreationInfo>(creationInfo);
        Assert.Equal("CreationInfo", creationInfo.Type);
        Assert.Equal("urn:CreationInfo:3f5", creationInfo.SpdxId);
    }

    [Fact]
    public void CreationInfo_FullyPopulated_SerializesAsExpected()
    {
        // Arrange
        var factory = new SpdxClassFactory
        {
            CreationDate = new DateTimeOffset(2025, 02, 23, 1, 23, 45, 0, TimeSpan.Zero)
        };

        // Act
        var creationInfo = factory.New<CreationInfo>();
        creationInfo.Comment = "Test comment";
        creationInfo.CreatedBy.Add(factory.New<Agent>(creationInfo));
        creationInfo.CreatedUsing.Add(factory.New<Tool>(creationInfo));


        // Assert
        const string expected = """
                                {
                                  "createdBy": [
                                    "urn:Agent:402"
                                  ],
                                  "comment": "Test comment",
                                  "created": "2025-02-23T01:23:45Z",
                                  "createdUsing": [
                                    "urn:Tool:40f"
                                  ],
                                  "specVersion": "3.0.1",
                                  "type": "CreationInfo",
                                  "spdxId": "urn:CreationInfo:3f5"
                                }
                                """;
        var json = creationInfo.ToJson();
        Assert.Equal(expected, json);
    }


    [Fact]
    public void CreationInfo_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var factory = new SpdxClassFactory
        {
            CreationDate = new DateTimeOffset(2025, 02, 23, 1, 23, 45, 0, TimeSpan.Zero)
        };

        // Act
        var creationInfo = factory.New<CreationInfo>();

        // Assert - note that empty collections are not serialized at all
        const string expected = """
                                {
                                  "created": "2025-02-23T01:23:45Z",
                                  "specVersion": "3.0.1",
                                  "type": "CreationInfo",
                                  "spdxId": "urn:CreationInfo:3f5"
                                }
                                """;
        var json = creationInfo.ToJson();
        Assert.Equal(expected, json);
    }
}