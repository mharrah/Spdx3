using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model;

/// <summary>
///     This is a base class for like EVERYTHING in an SPDX document, whether it's an "Element" or some other "Non-Element"
///     class.
///     See https://spdx.github.io/spdx-spec/v3.0.1/annexes/rdf-model/
/// </summary>
public abstract class BaseSpdxClass
{
    
    // protected internal no-parm constructor required for deserialization
    protected internal BaseSpdxClass()
    {
    }

    [SetsRequiredMembers]
    protected BaseSpdxClass(SpdxCatalog spdxCatalog)
    {
        Type = SpdxUtility.SpdxTypeForClass(GetType());
        SpdxId = spdxCatalog.NewId(GetType());
        spdxCatalog.Items[SpdxId] = this;
    }

    [JsonPropertyName("type")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required string Type { get; set; }

    [JsonPropertyName("spdxId")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required string SpdxId { get; init; }

    
    public virtual void Validate()
    {
        ValidateRequiredProperty(nameof(SpdxId));
        ValidateRequiredProperty(nameof(Type));
    }

    protected void ValidateRequiredProperty(string propertyName)
    {
        var propertyInfo = GetType().GetProperty(propertyName);
        if (propertyInfo == null)
        {
            throw new Spdx3ValidationException(this, $"'{propertyName}'", "No such property exists");
        }
        var propVal = propertyInfo.GetValue(this);
        if (propVal == null)
        {
            throw new Spdx3ValidationException(this, propertyName, "Field is required");
        }

        if (propVal is string && propVal.ToString() == string.Empty)
        {
            throw new Spdx3ValidationException(this, propertyName, "Field is empty");
        }
    }
}