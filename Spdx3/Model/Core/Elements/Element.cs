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
    public string? Comment { get; set; }

    [JsonPropertyName("creationInfo")]
    public string? CreationInfoSpdxId { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("extension")]
    [JsonConverter(typeof(SpdxCollectionConverterFactory))]
    public IList<Extension.Extension> Extensions { get; set; } = new List<Extension.Extension>();

    [JsonPropertyName("externalIdentifier")]
    [JsonConverter(typeof(SpdxCollectionConverterFactory))]
    public IList<ExternalIdentifier> ExternalIdentifiers { get; set; } = new List<ExternalIdentifier>();

    [JsonPropertyName("externalRef")]
    [JsonConverter(typeof(SpdxCollectionConverterFactory))]
    public IList<ExternalRef> ExternalRefs { get; set; } = new List<ExternalRef>();

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    [JsonPropertyName("verifiedUsing")]
    [JsonConverter(typeof(SpdxCollectionConverterFactory))]
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