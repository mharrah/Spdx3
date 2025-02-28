using System.Text.Json.Serialization;
using Spdx3.Model.Core.NonElements;
using Spdx3.Serialization;

namespace Spdx3.Model.Core.Elements;

/// <summary>
///     Base domain class from which all other SPDX-3.0 domain classes derive
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Element/
/// </summary>
public abstract class Element : BaseSpdxClass
{
    [JsonPropertyName("comment")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Comment { get; set; }

    [JsonPropertyName("creationInfo")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? CreationInfoSpdxId { get; set; }

    [JsonPropertyName("description")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Description { get; set; }

    [JsonPropertyName("extension")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<Extension.Extension> Extension { get; } = new List<Extension.Extension>();

    [JsonPropertyName("externalIdentifier")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<ExternalIdentifier> ExternalIdentifier { get; } = new List<ExternalIdentifier>();

    [JsonPropertyName("externalRef")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<ExternalRef> ExternalRef { get; } = new List<ExternalRef>();

    [JsonPropertyName("name")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Name { get; set; }

    [JsonPropertyName("summary")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Summary { get; set; }

    [JsonPropertyName("verifiedUsing")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<IntegrityMethod> VerifiedUsing { get; set; } = new List<IntegrityMethod>();

    public new void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(CreationInfoSpdxId));
        ValidateRequiredProperty(nameof(Type));
    }

    protected internal Element()
    {
    }

    protected Element(CreationInfo creationInfo)
    {
        CreationInfoSpdxId = creationInfo.SpdxId;
    }
}