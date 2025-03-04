using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A mapping between prefixes and namespace partial URIs.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/NamespaceMap/
/// </summary>
public class NamespaceMap : BaseSpdxClass
{
    [SetsRequiredMembers]
    public NamespaceMap(SpdxIdFactory spdxIdFactory, string prefix, string @namespace) : base(spdxIdFactory)
    {
        Prefix = prefix;
        Namespace = @namespace;
    }

    [JsonPropertyName("prefix")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required string Prefix { get; set; }

    [JsonPropertyName("namespace")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required string Namespace { get; set; }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Prefix));
        ValidateRequiredProperty(nameof(Namespace));
    }
}