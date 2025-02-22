using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.NonElements;

namespace Spdx3.Tests.Model.Core.NonElements;

public class CreationInfoTest : BaseElementTestClass
{
    private readonly DateTimeOffset _predictableDateTimeOffset = new(2025, 2, 18, 8, 52, 16, TimeSpan.Zero);

    [Fact]
    public void CreationInfo_ConstructorGeneratesId()
    {
        var creationInfo = new CreationInfo(TestIdFactory, new List<Agent>(), _predictableDateTimeOffset);
        Assert.NotNull(creationInfo);
        Assert.Equal("urn:CreationInfo:testRef", creationInfo.SpdxId);
    }

    [Fact]
    public void CreationInfo_IsSerializableToJson()
    {
        var creationInfo = new CreationInfo(TestIdFactory, new List<Agent>(), _predictableDateTimeOffset)
        {
            Comment = "Test Comment"
        };
        var json = creationInfo.ToJson();
        const string expected = """
                                {
                                  "specVersion": "3.0.1",
                                  "created": "2025-02-18T08:52:16+00:00",
                                  "comment": "Test Comment",
                                  "type": "CreationInfo",
                                  "spdxId": "urn:CreationInfo:testRef"
                                }
                                """;
        Assert.Equal(expected, json);
    }
}