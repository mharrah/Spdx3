using Spdx3.Model.Core.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class DictionaryEntryTest : BaseModelTestClass
{
    [Fact]
    public void DictionaryEntry_Basics()
    {
        var dictionaryEntry = new DictionaryEntry(TestSpdxIdFactory, "foo", "bar");

        // Assert
        Assert.NotNull(dictionaryEntry);
        Assert.IsType<DictionaryEntry>(dictionaryEntry);
        Assert.Equal("DictionaryEntry", dictionaryEntry.Type);
        Assert.Equal("urn:DictionaryEntry:402", dictionaryEntry.SpdxId);
    }

    [Fact]
    public void DictionaryEntry_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var dictionaryEntry = new DictionaryEntry(TestSpdxIdFactory, "TestKey")
        {
            Value = "TestValue"
        };
        const string expected = """
                                {
                                  "key": "TestKey",
                                  "value": "TestValue",
                                  "type": "DictionaryEntry",
                                  "spdxId": "urn:DictionaryEntry:402"
                                }
                                """;

        // Act
        var json = dictionaryEntry.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}