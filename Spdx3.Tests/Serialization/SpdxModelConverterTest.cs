using System.Text.Json;
using System.Text.Json.Serialization;
using Spdx3.Model;
using Spdx3.Model.AI.Enums;
using Spdx3.Serialization;

// ReSharper disable CollectionNeverUpdated.Global

namespace Spdx3.Tests.Serialization;

public class SpdxModelConverterTest
{
    [Fact]
    public void LoadJsonStringIntoProperty_Read_Handles_ListOfEnums()
    {
        var opts = new JsonSerializerOptions();
        opts.Converters.Add(new SpdxModelConverterFactory());

        var c = new SpdxModelConverterFactory().CreateConverter(typeof(TestClassWithCertainPropertyTypes), opts);
        var json = """
                   {
                     "listOfEnums": [
                        "kilowattHour",
                        "other"
                     ]   
                   }
                   """;
        var obj = JsonSerializer.Deserialize<TestClassWithCertainPropertyTypes>(json, opts);
        Assert.IsType<TestClassWithCertainPropertyTypes>(obj);
        Assert.Equal(2, obj.ListOfEnums.Count);
    }


    [Fact]
    public void LoadJsonStringIntoProperty_Read_Handles_ListOfDateTimeOffsets()
    {
        var opts = new JsonSerializerOptions();
        opts.Converters.Add(new SpdxModelConverterFactory());

        var c = new SpdxModelConverterFactory().CreateConverter(typeof(TestClassWithCertainPropertyTypes), opts);
        var json = """
                   {
                     "listOfDateTimeOffsets": [
                        "2025-04-01T00:00:00Z",
                        "2025-10-31T00:00:00Z",
                        "2025-12-25T00:00:00Z"
                     ]   
                   }
                   """;
        var obj = JsonSerializer.Deserialize<TestClassWithCertainPropertyTypes>(json, opts);
        Assert.IsType<TestClassWithCertainPropertyTypes>(obj);
        Assert.Equal(3, obj.ListOfDateTimeOffsets.Count);
    }

    

    [Fact]
    public void LoadJsonStringIntoProperty_Read_Handles_NullableDateTimeOffset()
    {
        var opts = new JsonSerializerOptions();
        opts.Converters.Add(new SpdxModelConverterFactory());

        var c = new SpdxModelConverterFactory().CreateConverter(typeof(TestClassWithCertainPropertyTypes), opts);
        var json = """
                   {
                     "nullableDateTimeOffset": "2025-04-01T00:00:00Z"
                   }
                   """;
        var obj = JsonSerializer.Deserialize<TestClassWithCertainPropertyTypes>(json, opts);
        Assert.IsType<TestClassWithCertainPropertyTypes>(obj);
        Assert.NotNull(obj.NullableDateTimeOffset);
    }

    
    public class TestClassWithCertainPropertyTypes : BaseModelClass
    {
        [JsonPropertyName("listOfEnums")]
        [JsonConverter(typeof(SpdxModelConverterFactory))]
        public List<EnergyUnitType> ListOfEnums { get; init; } = new();

        [JsonPropertyName("listOfDateTimeOffsets")]
        [JsonConverter(typeof(SpdxModelConverterFactory))]
        public List<DateTimeOffset> ListOfDateTimeOffsets { get; init; } = new();

        [JsonPropertyName("nullableDateTimeOffset")]
        [JsonConverter(typeof(SpdxModelConverterFactory))]
        public DateTimeOffset? NullableDateTimeOffset { get; set; }

    }
}