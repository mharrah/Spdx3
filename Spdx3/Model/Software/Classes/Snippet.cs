using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Classes;

public class Snippet : SoftwareArtifact
{
#pragma warning disable CS8618, CS9264
    // protected internal no-parm constructor required for deserialization
    protected internal Snippet()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public Snippet(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo, File snippetFromFile) : base(spdxIdFactory,
        creationInfo)
    {
        SnippetFromFile = snippetFromFile;
    }

    [JsonPropertyName("byteRange")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public PositiveIntegerRange? ByteRange { get; set; }

    [JsonPropertyName("lineRange")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public PositiveIntegerRange? LineRange { get; set; }

    [JsonPropertyName("snippetFromFile")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public File SnippetFromFile { get; set; }

    public override void Validate()
    {
        base.Validate();
        if (SnippetFromFile == null)
        {
            throw new Spdx3ValidationException(this, nameof(SnippetFromFile), "Cannot be null, empty, or whitespace.");
        }
    }
}