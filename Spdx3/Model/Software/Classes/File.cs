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


    [SetsRequiredMembers]
    public File(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo, string name) : base(spdxIdFactory, creationInfo)
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