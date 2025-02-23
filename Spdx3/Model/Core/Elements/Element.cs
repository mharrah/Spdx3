using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.NonElements;

namespace Spdx3.Model.Core.Elements;

public abstract class Element : BaseSpdxClass
{
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
    
    [JsonPropertyName("creationInfo")]
    public required string CreationInfoSpdxId { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /*
       extension	/Extension/Extension	0	*
       externalIdentifier	ExternalIdentifier	0	*
       externalRef	ExternalRef	0	*
    */

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /*
    verifiedUsing	IntegrityMethod	0	*
    */
    

}

