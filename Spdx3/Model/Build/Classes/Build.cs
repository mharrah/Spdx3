using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Build.Classes;

public class Build : Element
{
    [JsonPropertyName("buildEndTime")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public DateTimeOffset? BuildEndTime { get; set; }

    [JsonPropertyName("buildId")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? BuildId { get; set; }
    
    [JsonPropertyName("buildStartTime")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public DateTimeOffset? BuildStartTime { get; set; }
    
    [JsonPropertyName("buildType")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required Uri BuildType { get; set; }

    [JsonPropertyName("configSourceDigest")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<Hash> ConfigSourceDigest { get; set; } = new List<Hash>();

    [JsonPropertyName("configSourceEntrypoint")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<string> ConfigSourceEntrypoint { get; set; } = new List<string>();

    [JsonPropertyName("configSourceUri")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<Uri> ConfigSourceUri { get; set; } = new List<Uri>();

    [JsonPropertyName("environment")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<DictionaryEntry> Environment { get; set; } = new List<DictionaryEntry>();

    [JsonPropertyName("configSourceUri")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<DictionaryEntry> Parameter { get; set; } = new List<DictionaryEntry>();
    
    // protected internal no-parm constructor required for deserialization
    protected internal Build()
    {
    }
    
    [SetsRequiredMembers]
    public Build(SpdxCatalog spdxCatalog, CreationInfo creationInfo, Uri buildType) : base(spdxCatalog, creationInfo)
    {
        BuildType = buildType;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(BuildType));
    }
}