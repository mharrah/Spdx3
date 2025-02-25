using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.NonElements;

public class PositiveIntegerRangeTest : BaseSpdxClassTestClass
{
    [Fact]
    public void PositiveIntegerRange_Basics()
    {
        // Arrange
        var factory = new SpdxClassFactory();

        // Act
        var positiveIntegerRange = factory.New<PositiveIntegerRange>();

        // Assert
        Assert.NotNull(positiveIntegerRange);
        Assert.IsType<PositiveIntegerRange>(positiveIntegerRange);
        Assert.Equal("PositiveIntegerRange", positiveIntegerRange.Type);
        Assert.Equal("urn:PositiveIntegerRange:3f5", positiveIntegerRange.SpdxId);
    }

    [Fact]
    public void PositiveIntegerRange_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var positiveIntegerRange = TestFactory.New<PositiveIntegerRange>();
        positiveIntegerRange.BeginIntegerRange = 1;
        positiveIntegerRange.EndIntegerRange = 5;
        const string expected = """
                                {
                                  "beginIntegerRange": 1,
                                  "endIntegerRange": 5,
                                  "type": "PositiveIntegerRange",
                                  "spdxId": "urn:PositiveIntegerRange:3f5"
                                }
                                """;

        // Act
        var json = positiveIntegerRange.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void PositiveIntegerRange_FailsValidation_WhenMissing_BeginIntegerRange()
    {
        // Arrange
        var positiveIntegerRange = TestFactory.New<PositiveIntegerRange>();
        // Don't set positiveIntegerRange.BeginIntegerRange, it default to null
        positiveIntegerRange.EndIntegerRange = 5;

        //  Act
        var exception = Record.Exception(() => positiveIntegerRange.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object PositiveIntegerRange, property BeginIntegerRange: Field is required", exception.Message);
    }

    [Fact]
    public void PositiveIntegerRange_FailsValidation_WhenMissing_EndIntegerRange()
    {
        // Arrange
        var positiveIntegerRange = TestFactory.New<PositiveIntegerRange>();
        positiveIntegerRange.BeginIntegerRange = 1;
        // Don't set positiveIntegerRange.EndIntegerRange, it defaults to null

        //  Act
        var exception = Record.Exception(() => positiveIntegerRange.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object PositiveIntegerRange, property EndIntegerRange: Field is required", exception.Message);
    }
    
    [Fact]
    public void PositiveIntegerRange_Setter_DoesNotThrowIf_BeginIntegerRange_IsPositive()
    {
        var p = new PositiveIntegerRange();
        var exception = Record.Exception(() =>
            {
                p.BeginIntegerRange = 1;
                p.BeginIntegerRange = 2;
                p.BeginIntegerRange = int.MaxValue;
            }
        );
        Assert.Null(exception);
    }

    [Fact]
    public void PositiveIntegerRange_Setter_ThrowsIf_BeginIntegerRange_Null()
    {
        var p = new PositiveIntegerRange();
        var exception = Record.Exception(() => { p.BeginIntegerRange = null; });
        Assert.NotNull(exception);
    }


    [Fact]
    public void PositiveIntegerRange_Setter_ThrowsExceptionIf_BeginIntegerRange_IsZero()
    {
        var p = new PositiveIntegerRange();
        var exception = Record.Exception(() => { p.BeginIntegerRange = 0; });
        Assert.NotNull(exception);
    }
    
    
    [Fact]
    public void PositiveIntegerRange_Setter_ThrowsExceptionIf_BeginIntegerRange_IsNegative()
    {
        var p = new PositiveIntegerRange();
        var exception = Record.Exception(() => { p.EndIntegerRange = -1; });
        Assert.NotNull(exception);
    }

    [Fact]
    public void PositiveIntegerRange_Setter_DoesNotThrowIf_EndIntegerRange_IsPositive()
    {
        var p = new PositiveIntegerRange();
        var exception = Record.Exception(() =>
            {
                p.EndIntegerRange = 1;
                p.EndIntegerRange = 2;
                p.EndIntegerRange = int.MaxValue;
            }
        );
        Assert.Null(exception);
    }

    [Fact]
    public void PositiveIntegerRange_Setter_ThrowsIf_EndIntegerRange_Null()
    {
        var p = new PositiveIntegerRange();
        var exception = Record.Exception(() => { p.EndIntegerRange = null; });
        Assert.NotNull(exception);
    }


    [Fact]
    public void PositiveIntegerRange_Setter_ThrowsExceptionIf_EndIntegerRange_IsZero()
    {
        var p = new PositiveIntegerRange();
        var exception = Record.Exception(() => { p.EndIntegerRange = 0; });
        Assert.NotNull(exception);
    }
    
    
    [Fact]
    public void PositiveIntegerRange_Setter_ThrowsExceptionIf_EndIntegerRange_IsNegative()
    {
        var p = new PositiveIntegerRange();
        var exception = Record.Exception(() => { p.EndIntegerRange = -1; });
        Assert.NotNull(exception);
    }

}