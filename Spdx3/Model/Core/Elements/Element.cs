using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Elements;

/// <summary>
/// These are SPDX elements that make up the Core profile.  
/// Note that many classes in SPDX don't descend from this class, because they're technically not "elements".
/// As a practical upshot of this, this class includes a number of properties that are on every element and which may not be on the Non-Element classes.
/// See https://spdx.github.io/spdx-spec/v3.0.1/annexes/rdf-model/
/// 
/// </summary>
public abstract class Element : BaseSpdxClass
{

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("creationInfo")]
    public string CreationInfoSpdxId { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("extension")]
    public string? ExtensionSpdxId { get; set; }

    [JsonPropertyName("externalIdentifier")]
    public string? ExternalIdentifierSpdxId { get; set; }

    [JsonPropertyName("externalRef")]
    public string? ExternalRefSpdxId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    [JsonPropertyName("verifiedUsing")]
    public string? VerifiedUsingSpxdId { get; set; }

    [SetsRequiredMembers]
    protected Element(ISpdxIdFactory idFactory, string elementType, CreationInfo creationInfo) : base(idFactory, elementType)
    {
        CreationInfoSpdxId = creationInfo.SpdxId;
    }
}