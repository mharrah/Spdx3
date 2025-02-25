using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.NonElements;

public class CreationInfoTest
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
        var factory = new SpdxClassFactory();
        factory.CreationDate = new DateTimeOffset(2025, 02, 23, 1, 23, 45, 0, TimeSpan.Zero);

        // Act
        var creationInfo = factory.New<CreationInfo>();
        creationInfo.Comment = "Test comment";
        creationInfo.CreatedByAgentRefs.Add("testref");
        creationInfo.CreatedUsingToolRefs.Add("testref");


        // Assert
        var expected = """
                       {
                         "createdBy": [
                           "testref"
                         ],
                         "comment": "Test comment",
                         "created": "2025-02-23T01:23:45+00:00",
                         "createdUsing": [
                           "testref"
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
        var factory = new SpdxClassFactory();
        factory.CreationDate = new DateTimeOffset(2025, 02, 23, 1, 23, 45, 0, TimeSpan.Zero);

        // Act
        var creationInfo = factory.New<CreationInfo>();

        // Assert - note that empty collections are not serialized at all
        var expected = """
                       {
                         "created": "2025-02-23T01:23:45+00:00",
                         "specVersion": "3.0.1",
                         "type": "CreationInfo",
                         "spdxId": "urn:CreationInfo:3f5"
                       }
                       """;
        var json = creationInfo.ToJson();
        Assert.Equal(expected, json);
    }
}