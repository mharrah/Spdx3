using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A map of Element identifiers that are used within an SpdxDocument but defined external to that SpdxDocument.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ExternalMap/
/// </summary>
public class ExternalMap : BaseModelClass
{
    [JsonPropertyName("definingArtifact")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public Artifact? DefiningArtifact { get; set; }

    [JsonPropertyName("externalSpdxId")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required string ExternalSpdxId { get; set; }

    [JsonPropertyName("locationHint")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public Uri? LocationHint { get; set; }

    [JsonPropertyName("verifiedUsing")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<IntegrityMethod> VerifiedUsing { get; } = new List<IntegrityMethod>();

    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once UnusedMember.Global
    protected internal ExternalMap()
    {
    }

    [SetsRequiredMembers]
    public ExternalMap(Catalog catalog, string externalSpdxId) : base(catalog)
    {
        ExternalSpdxId = externalSpdxId;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(ExternalSpdxId));
    }
}