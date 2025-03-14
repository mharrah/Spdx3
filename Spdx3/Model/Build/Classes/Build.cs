using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Build.Classes;

public class Build : Element
{
    [JsonPropertyName("build_buildEndTime")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public DateTimeOffset? BuildEndTime { get; set; }

    [JsonPropertyName("build_buildId")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? BuildId { get; set; }

    [JsonPropertyName("build_buildStartTime")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public DateTimeOffset? BuildStartTime { get; set; }

    [JsonPropertyName("build_buildType")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required Uri BuildType { get; set; }

    [JsonPropertyName("build_configSourceDigest")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<Hash> ConfigSourceDigest { get; set; } = new List<Hash>();

    [JsonPropertyName("build_configSourceEntrypoint")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<string> ConfigSourceEntrypoint { get; set; } = new List<string>();

    [JsonPropertyName("build_configSourceUri")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<Uri> ConfigSourceUri { get; set; } = new List<Uri>();

    [JsonPropertyName("build_environment")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<DictionaryEntry> Environment { get; } = new List<DictionaryEntry>();

    [JsonPropertyName("build_parameter")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<DictionaryEntry> Parameter { get;  } = new List<DictionaryEntry>();

    // protected internal no-parm constructor required for deserialization
    protected internal Build()
    {
    }

    [SetsRequiredMembers]
    public Build(Catalog catalog, CreationInfo creationInfo, Uri buildType) : base(catalog, creationInfo)
    {
        BuildType = buildType;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(BuildType));
    }
}