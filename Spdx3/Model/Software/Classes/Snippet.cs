using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Classes;

public class Snippet : SoftwareArtifact
{
    [JsonPropertyName("byteRange")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public PositiveIntegerRange? ByteRange { get; set; }

    [JsonPropertyName("lineRange")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public PositiveIntegerRange? LineRange { get; set; }

    [JsonPropertyName("snippetFromFile")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public File SnippetFromFile { get; set; }
#pragma warning disable CS8618, CS9264
    // protected internal no-parm constructor required for deserialization
    protected internal Snippet()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public Snippet(Catalog catalog, CreationInfo creationInfo, File snippetFromFile) : base(catalog,
        creationInfo)
    {
        SnippetFromFile = snippetFromFile;
    }

    public override void Validate()
    {
        base.Validate();
        if (SnippetFromFile == null)
        {
            throw new Spdx3ValidationException(this, nameof(SnippetFromFile), "Cannot be null, empty, or whitespace.");
        }
    }
}