using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
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
public abstract class BaseModelClass
{
    [JsonPropertyName("type")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required string Type { get; set; }

    [JsonPropertyName("spdxId")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required Uri SpdxId { get; set; }

    // protected internal no-parm constructor required for deserialization
    protected internal BaseModelClass()
    {
    }

    [SetsRequiredMembers]
    protected BaseModelClass(Catalog catalog)
    {
        Type = Naming.SpdxTypeForClass(GetType());
        SpdxId = catalog.NewId(GetType());
        catalog.Items[SpdxId] = this;
    }


    public virtual void Validate()
    {
        ValidateRequiredProperty(nameof(SpdxId));
        ValidateRequiredProperty(nameof(Type));
    }

    protected void ValidateRequiredProperty(string propertyName)
    {
        var props = GetType().GetProperties().Where(p => p.Name == propertyName).ToList();
        PropertyInfo? propertyInfo = null;
        if (props.Count > 1)
        {
            propertyInfo = props.Single(p => p.GetCustomAttribute<RequiredMemberAttribute>() != null);
        }
        else
        {
            propertyInfo = props.FirstOrDefault();
        }
        if (propertyInfo == null)
        {
            throw new Spdx3ValidationException(this, $"'{propertyName}'", "No such property exists");
        }

        var propVal = propertyInfo.GetValue(this);
        switch (propVal)
        {
            case null:
                throw new Spdx3ValidationException(this, propertyName, "Field is required");
            case string when propVal.ToString() == string.Empty:
                throw new Spdx3ValidationException(this, propertyName, "String field is empty");
            case IList { Count: 0 }:
                throw new Spdx3ValidationException(this, propertyName, "List is empty");
        }
    }
}