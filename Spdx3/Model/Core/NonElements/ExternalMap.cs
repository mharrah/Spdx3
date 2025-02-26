using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     A map of Element identifiers that are used within an SpdxDocument but defined external to that SpdxDocument.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ExternalMap/
/// </summary>
public class ExternalMap : BaseSpdxClass
{
    [JsonPropertyName("definingArtifact")]
    public string? DefiningArtifactRef { get; set; }

    [JsonPropertyName("externalSpdxId")]
    public string? ExternalSpdxId { get; set; }

    [JsonPropertyName("locationHint")]
    public string? LocationHint { get; set; }

    [JsonPropertyName("verifiedUsing")]
    public IList<string> VerifiedUsingRef { get; } = new List<string>();

    public new void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(ExternalSpdxId));
    }

    internal ExternalMap()
    {
        
    }
}