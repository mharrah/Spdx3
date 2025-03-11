using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A collection of Elements that have a shared context.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Bundle/
/// </summary>
public class Bundle : ElementCollection
{
    // protected internal no-parm constructor required for deserialization
    protected internal Bundle()
    {
    }
    
    [SetsRequiredMembers]
    public Bundle(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory, creationInfo)
    {
    }

    [JsonPropertyName("context")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<string> Context { get; } = new List<string>();
}