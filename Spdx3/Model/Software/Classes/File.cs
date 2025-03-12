using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Classes;

public class File : SoftwareArtifact
{
    private string _name;

    [JsonPropertyName("contentType")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? ContentType { get; set; }

    [JsonPropertyName("fileKind")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public FileKindType? FileKind { get; set; }

    [JsonPropertyName("name")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public new string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Spdx3ValidationException(this, nameof(Name), "Cannot be null, empty, or whitespace.");
            }

            _name = value;
        }
    }

    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal File()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public File(Catalog catalog, CreationInfo creationInfo, string name) : base(catalog, creationInfo)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new Spdx3ValidationException(this, nameof(Name), "Cannot be null, empty, or whitespace.");
        }

        _name = name;
    }


    public override void Validate()
    {
        base.Validate();
        if (string.IsNullOrWhiteSpace(Name))
        {
            throw new Spdx3ValidationException(this, nameof(Name), "Cannot be null, empty, or whitespace.");
        }
    }
}