using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model.Core.NonElements;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Elements;

public class Snippet : SoftwareArtifact
{
    
    [JsonPropertyName("byteRange")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public PositiveIntegerRange? ByteRange { get; set; }
    
    [JsonPropertyName("lineRange")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public PositiveIntegerRange? LineRange { get; set; }

    [JsonPropertyName("snippetFromFile")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public File SnippetFromFile { get; set; }
    

    [SetsRequiredMembers]
    public Snippet(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo, File snippetFromFile) : base(spdxIdFactory,
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