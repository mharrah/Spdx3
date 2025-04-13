using System.Text.Json.Serialization;
using Spdx3.Serialization;

namespace Spdx3.Model;

public interface IModelClass
{
    
    [JsonPropertyName("spdxId")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public Uri SpdxId { get; set; }

    // Perform class-specific but domain-agnostic validations
    void Validate();
    
    // Accept a visitor (using visitor design pattern)
    void Accept(IModelVisitor visitor);
}