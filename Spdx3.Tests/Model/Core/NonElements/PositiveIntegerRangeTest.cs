using Spdx3.Model.Core.NonElements;

namespace Spdx3.Tests.Model.Core.NonElements;

public class PositiveIntegerRangeTest : BaseModelTestClass
{
    [Fact]
    public void PositiveIntegerRange_Basics()
    {
        var positiveIntegerRange = new PositiveIntegerRange(TestSpdxIdFactory, 1, 5);

        // Assert
        Assert.NotNull(positiveIntegerRange);
        Assert.IsType<PositiveIntegerRange>(positiveIntegerRange);
        Assert.Equal("PositiveIntegerRange", positiveIntegerRange.Type);
        Assert.Equal("urn:PositiveIntegerRange:402", positiveIntegerRange.SpdxId);
    }

    [Fact]
    public void PositiveIntegerRange_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var positiveIntegerRange = new PositiveIntegerRange(TestSpdxIdFactory, 1, 5);
        const string expected = """
                                {
                                  "beginIntegerRange": 1,
                                  "endIntegerRange": 5,
                                  "type": "PositiveIntegerRange",
                                  "spdxId": "urn:PositiveIntegerRange:402"
                                }
                                """;

        // Act
        var json = positiveIntegerRange.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void PositiveIntegerRange_Setter_ThrowsExceptionIf_BeginIntegerRange_IsZero()
    {
        var exception = Record.Exception(() => { new PositiveIntegerRange(TestSpdxIdFactory, 0, 5); });
        Assert.NotNull(exception);
    }


    [Fact]
    public void PositiveIntegerRange_Setter_ThrowsExceptionIf_BeginIntegerRange_IsNegative()
    {
        var exception = Record.Exception(() => { new PositiveIntegerRange(TestSpdxIdFactory, -1, 5); });
        Assert.NotNull(exception);
    }
}