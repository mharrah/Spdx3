using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A reference to a resource outside the scope of SPDX-3.0 content related to an Element.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ExternalRef/
/// </summary>
public class ExternalRef : BaseModelClass
{
    [JsonPropertyName("externalRefType")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required ExternalRefType ExternalRefType { get; set; }

    [JsonPropertyName("locator")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<string> Locator { get; set; } = new List<string>();

    [JsonPropertyName("contentType")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? ContentType { get; set; }

    [JsonPropertyName("comment")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? Comment { get; set; }

    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once UnusedMember.Global
    protected internal ExternalRef()
    {
    }

    [SetsRequiredMembers]
    public ExternalRef(Catalog catalog, ExternalRefType externalRefType) : base(catalog)
    {
        ExternalRefType = externalRefType;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(ExternalRefType));
    }
}