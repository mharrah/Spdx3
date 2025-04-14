using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Lite;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A mathematically calculated representation of a grouping of data.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Hash/
/// </summary>
public class Hash : IntegrityMethod, ILiteDomainCompliantElement
{
    [JsonPropertyName("algorithm")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required HashAlgorithm Algorithm { get; set; }

    [JsonPropertyName("hashValue")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required string HashValue { get; set; }

    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once UnusedMember.Global
    protected internal Hash()
    {
    }

    [SetsRequiredMembers]
    public Hash(Catalog catalog, HashAlgorithm algorithm, string hashValue) : base(catalog)
    {
        Algorithm = algorithm;
        HashValue = hashValue;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Algorithm));
        ValidateRequiredProperty(nameof(HashValue));
    }

    public void Accept(ILiteDomainComplianceVisitor visitor)
    {
        visitor.Visit(this);
    }
}