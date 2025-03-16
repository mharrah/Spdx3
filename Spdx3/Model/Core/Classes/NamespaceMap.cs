using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A mapping between prefixes and namespace partial URIs.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/NamespaceMap/
/// </summary>
public class NamespaceMap : BaseModelClass
{
    [JsonPropertyName("prefix")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required string Prefix { get; set; }

    [JsonPropertyName("namespace")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required string Namespace { get; set; }

    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once UnusedMember.Global
    protected internal NamespaceMap()
    {
    }

    [SetsRequiredMembers]
    public NamespaceMap(Catalog catalog, string prefix, string @namespace) : base(catalog)
    {
        Prefix = prefix;
        Namespace = @namespace;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Prefix));
        ValidateRequiredProperty(nameof(Namespace));
    }
}