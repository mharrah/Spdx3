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
    
    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal File()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public File(SpdxCatalog spdxCatalog, CreationInfo creationInfo, string name) : base(spdxCatalog, creationInfo)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new Spdx3ValidationException(this, nameof(Name), "Cannot be null, empty, or whitespace.");
        }

        _name = name;
    }

    [JsonPropertyName("contentType")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? ContentType { get; set; }

    [JsonPropertyName("fileKind")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public FileKindType? FileKind { get; set; }

    [JsonPropertyName("name")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
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


    public override void Validate()
    {
        base.Validate();
        if (string.IsNullOrWhiteSpace(Name))
        {
            throw new Spdx3ValidationException(this, nameof(Name), "Cannot be null, empty, or whitespace.");
        }
    }
}