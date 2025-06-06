using Spdx3.Model.Core.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class PositiveIntegerRangeTest : BaseModelTest
{
    [Fact]
    public void PositiveIntegerRange_Basics()
    {
        var positiveIntegerRange = new PositiveIntegerRange(TestCatalog, 1, 5);

        // Assert
        Assert.NotNull(positiveIntegerRange);
        Assert.IsType<PositiveIntegerRange>(positiveIntegerRange);
        Assert.Equal("PositiveIntegerRange", positiveIntegerRange.Type);
        Assert.Equal(new Uri("urn:PositiveIntegerRange:40f"), positiveIntegerRange.SpdxId);
    }

    [Fact]
    public void PositiveIntegerRange_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var positiveIntegerRange = new PositiveIntegerRange(TestCatalog, 1, 5);
        const string expected = """
                                {
                                  "beginIntegerRange": 1,
                                  "endIntegerRange": 5,
                                  "type": "PositiveIntegerRange",
                                  "spdxId": "urn:PositiveIntegerRange:40f"
                                }
                                """;

        // Act
        var json = ToJson(positiveIntegerRange);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void PositiveIntegerRange_Setter_ThrowsExceptionIf_BeginIntegerRange_IsZero()
    {
        var exception = Record.Exception(() =>
        {
            // ReSharper disable once ObjectCreationAsStatement
#pragma warning disable CA1806
            new PositiveIntegerRange(TestCatalog, 0, 5);
#pragma warning restore CA1806
        });
        Assert.NotNull(exception);
    }


    [Fact]
    public void PositiveIntegerRange_Setter_ThrowsExceptionIf_EndLessThanBegin()
    {
        var exception = Record.Exception(() =>
        {
            // ReSharper disable once ObjectCreationAsStatement
#pragma warning disable CA1806
            new PositiveIntegerRange(TestCatalog, 8, 5);
#pragma warning restore CA1806
        });
        Assert.NotNull(exception);
    }


    [Fact]
    public void PositiveIntegerRange_Setter_ThrowsExceptionIf_BeginIntegerRange_IsNegative()
    {
        var exception = Record.Exception(() =>
        {
            // ReSharper disable once ObjectCreationAsStatement
#pragma warning disable CA1806
            new PositiveIntegerRange(TestCatalog, -1, 5);
#pragma warning restore CA1806
        });
        Assert.NotNull(exception);
    }

    [Fact]
    public void PositiveIntegerRange_CantUse_NegativeInteger_Start()
    {
        // Arrange
        var positiveIntegerRange = new PositiveIntegerRange(TestCatalog, 1, 5);

        // Act
        var exception = Record.Exception(() => positiveIntegerRange.BeginIntegerRange = -5);

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Value of -5 is not a positive non-zero integer", exception.Message);
    }


    [Fact]
    public void PositiveIntegerRange_CantUse_Zero_Start()
    {
        // Arrange
        var positiveIntegerRange = new PositiveIntegerRange(TestCatalog, 1, 5);

        // Act
        var exception = Record.Exception(() => positiveIntegerRange.BeginIntegerRange = 0);

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Value of 0 is not a positive non-zero integer", exception.Message);
    }


    [Fact]
    public void PositiveIntegerRange_Start_CantExceed_End()
    {
        // Arrange
        var positiveIntegerRange = new PositiveIntegerRange(TestCatalog, 1, 5);

        // Act
        var exception = Record.Exception(() => positiveIntegerRange.BeginIntegerRange = 6);

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Value of 6 cannot exceed end integer value of 5", exception.Message);
    }

    [Fact]
    public void PositiveIntegerRange_CantUse_NegativeInteger_End()
    {
        // Arrange
        var positiveIntegerRange = new PositiveIntegerRange(TestCatalog, 1, 5);

        // Act
        var exception = Record.Exception(() => positiveIntegerRange.EndIntegerRange = -5);

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Value of -5 is not a positive non-zero integer", exception.Message);
    }


    [Fact]
    public void PositiveIntegerRange_CantUse_Zero_End()
    {
        // Arrange
        var positiveIntegerRange = new PositiveIntegerRange(TestCatalog, 1, 5);

        // Act
        var exception = Record.Exception(() => positiveIntegerRange.EndIntegerRange = 0);

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Value of 0 is not a positive non-zero integer", exception.Message);
    }


    [Fact]
    public void PositiveIntegerRange_End_CantBeLessThan_Start()
    {
        // Arrange
        var positiveIntegerRange = new PositiveIntegerRange(TestCatalog, 2, 5);

        // Act
        var exception = Record.Exception(() => positiveIntegerRange.EndIntegerRange = 1);

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Value of 1 cannot be less than begin integer value of 2", exception.Message);
    }
}