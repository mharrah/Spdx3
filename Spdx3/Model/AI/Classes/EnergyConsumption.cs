using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.AI.Classes;

public class EnergyConsumption : BaseModelClass
{
    [JsonPropertyName("ai_finetuningEnergyConsumption")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<EnergyConsumptionDescription> FinetuningEnergyConsumption { get; set; } =
        new List<EnergyConsumptionDescription>();

    [JsonPropertyName("ai_inferenceEnergyConsumption")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<EnergyConsumptionDescription> InferenceEnergyConsumption { get; set; } =
        new List<EnergyConsumptionDescription>();

    [JsonPropertyName("ai_trainingEnergyConsumption")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<EnergyConsumptionDescription> TrainingEnergyConsumption { get; set; } =
        new List<EnergyConsumptionDescription>();

    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal EnergyConsumption()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public EnergyConsumption(Catalog catalog) : base(catalog)
    {
    }
}