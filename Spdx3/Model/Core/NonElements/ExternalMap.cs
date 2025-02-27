using System.Text.Json.Serialization;
using Spdx3.Model.Core.Elements;
using Spdx3.Serialization;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     A map of Element identifiers that are used within an SpdxDocument but defined external to that SpdxDocument.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ExternalMap/
/// </summary>
public class ExternalMap : BaseSpdxClass
{
    [JsonPropertyName("definingArtifact")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public Artifact? DefiningArtifact { get; set; }

    [JsonPropertyName("externalSpdxId")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? ExternalSpdxId { get; set; }

    [JsonPropertyName("locationHint")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? LocationHint { get; set; }

    [JsonPropertyName("verifiedUsing")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<IntegrityMethod> VerifiedUsing { get; } = new List<IntegrityMethod>();

    public new void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(ExternalSpdxId));
    }

    internal ExternalMap()
    {
    }
}