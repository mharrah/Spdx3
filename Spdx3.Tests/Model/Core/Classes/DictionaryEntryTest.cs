using Spdx3.Model.Core.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class DictionaryEntryTest : BaseModelTest
{
    [Fact]
    public void DictionaryEntry_Basics()
    {
        var dictionaryEntry = new DictionaryEntry(TestCatalog, "foo", "bar");

        // Assert
        Assert.NotNull(dictionaryEntry);
        Assert.IsType<DictionaryEntry>(dictionaryEntry);
        Assert.Equal("DictionaryEntry", dictionaryEntry.Type);
        Assert.Equal(new Uri("urn:DictionaryEntry:40f"), dictionaryEntry.SpdxId);
    }

    [Fact]
    public void DictionaryEntry_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var dictionaryEntry = new DictionaryEntry(TestCatalog, "TestKey")
        {
            Value = "TestValue"
        };
        const string expected = """
                                {
                                  "key": "TestKey",
                                  "value": "TestValue",
                                  "type": "DictionaryEntry",
                                  "spdxId": "urn:DictionaryEntry:40f"
                                }
                                """;

        // Act
        var json = ToJson(dictionaryEntry);

        // Assert
        Assert.Equal(expected, json);
    }
}