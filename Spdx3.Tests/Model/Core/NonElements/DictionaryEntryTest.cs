using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.NonElements;

public class DictionaryEntryTest : BaseSpdxClassTestClass
{
    [Fact]
    public void DictionaryEntry_Basics()
    {
        // Arrange
        var factory = new SpdxClassFactory();

        // Act
        var dictionaryEntry = factory.New<DictionaryEntry>();

        // Assert
        Assert.NotNull(dictionaryEntry);
        Assert.IsType<DictionaryEntry>(dictionaryEntry);
        Assert.Equal("DictionaryEntry", dictionaryEntry.Type);
        Assert.Equal("urn:DictionaryEntry:3f5", dictionaryEntry.SpdxId);
    }

    [Fact]
    public void DictionaryEntry_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var dictionaryEntry = TestFactory.New<DictionaryEntry>();
        dictionaryEntry.Key = "TestKey";
        dictionaryEntry.Value = "TestValue";
        var expected = """
                       {
                         "key": "TestKey",
                         "value": "TestValue",
                         "type": "DictionaryEntry",
                         "spdxId": "urn:DictionaryEntry:3f5"
                       }
                       """;

        // Act
        var json = dictionaryEntry.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void DictionaryEntry_FailsValidation_WhenMissing_Key()
    {
        // Arrange
        var dictionaryEntry = TestFactory.New<DictionaryEntry>();
        dictionaryEntry.Key = null;
        ;
        dictionaryEntry.Value = "TestValue";

        //  Act
        var exception = Record.Exception(() => dictionaryEntry.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object DictionaryEntry, property Key: Field is required", exception.Message);
    }

    [Fact]
    public void DictionaryEntry_FailsValidation_WhenEmpty_Key()
    {
        // Arrange
        var dictionaryEntry = TestFactory.New<DictionaryEntry>();
        dictionaryEntry.Key = "";
        dictionaryEntry.Value = "TestValue";

        //  Act
        var exception = Record.Exception(() => dictionaryEntry.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object DictionaryEntry, property Key: Field is empty", exception.Message);
    }

    [Fact]
    public void DictionaryEntry_PassesValidation_WhenMissing_Value()
    {
        // Arrange
        var dictionaryEntry = TestFactory.New<DictionaryEntry>();
        dictionaryEntry.Key = "TestKey";
        dictionaryEntry.Value = null; // Null values are allowed!

        //  Act
        var exception = Record.Exception(() => dictionaryEntry.Validate());

        // Assert
        Assert.Null(exception);
    }

    [Fact]
    public void DictionaryEntry_PassesValidation_WhenEmpty_Value()
    {
        // Arrange
        var dictionaryEntry = TestFactory.New<DictionaryEntry>();
        dictionaryEntry.Key = "TestKey";
        dictionaryEntry.Value = ""; // Empty strings are ok!

        //  Act
        var exception = Record.Exception(() => dictionaryEntry.Validate());

        // Assert
        Assert.Null(exception);
    }
}