using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     Base domain class from which all other SPDX-3.0 domain classes derive
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Element/
/// </summary>
public abstract class Element : BaseSpdxClass
{
    // protected internal no-parm constructor required for deserialization
    protected internal Element()
    {
    }
    
    
    [SetsRequiredMembers]
    protected Element(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory)
    {
        CreationInfo = creationInfo;
    }

    [JsonPropertyName("comment")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Comment { get; set; }

    [JsonPropertyName("creationInfo")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required CreationInfo CreationInfo { get; set; }

    [JsonPropertyName("description")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Description { get; set; }

    [JsonPropertyName("extension")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<Extension.Classes.Extension> Extension { get; } = new List<Extension.Classes.Extension>();

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
    public IList<IntegrityMethod> VerifiedUsing { get; } = new List<IntegrityMethod>();

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(CreationInfo));
        ValidateRequiredProperty(nameof(Type));
    }
}