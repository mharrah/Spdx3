using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Elements;
using Spdx3.Utility;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     Provides information about the creation of the Element.
///     Generally, this is the first thing you should create when creating an SPDX document, and
///     most of the elements in the document are likely to reference this one CreationInfo element.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/CreationInfo/
/// </summary>
public class CreationInfo : BaseSpdxClass
{
    [SetsRequiredMembers]
    public CreationInfo(ISpdxIdFactory idFactory, IList<Agent> createdBy) : base(idFactory, "CreationInfo")
    {
        CreatedBy = createdBy;
    }

    [SetsRequiredMembers]
    public CreationInfo(ISpdxIdFactory idFactory, IList<Agent> createdBy, DateTimeOffset createdAt) : base(idFactory,
        "CreationInfo")
    {
        CreatedBy = createdBy;
        Created = createdAt;
    }

    [JsonPropertyName("specVersion")]
    public string SpecVersion { get; set; } = "3.0.1";

    [JsonPropertyName("created")]
    public DateTimeOffset Created { get; } = DateTimeOffset.Now;

    [JsonPropertyName("createdBy")]
    public IList<Agent> CreatedBy { get; } = new List<Agent>();

    [JsonPropertyName("createdUsing")]
    public IList<Tool> CreatedUsing { get; } = new List<Tool>();

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}