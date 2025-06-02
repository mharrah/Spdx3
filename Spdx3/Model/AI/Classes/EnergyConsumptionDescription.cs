using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.AI.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.AI.Classes;

public class EnergyConsumptionDescription : BaseModelClass
{
    [JsonPropertyName("ai_energyQuantity")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required double EnergyQuantity { get; set; }

    [JsonPropertyName("ai_energyUnit")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required EnergyUnitType EnergyUnit { get; set; }

    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal EnergyConsumptionDescription()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public EnergyConsumptionDescription(Catalog catalog, double energyQuantity, EnergyUnitType energyUnit) :
        base(catalog)
    {
        EnergyQuantity = energyQuantity;
        EnergyUnit = energyUnit;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(EnergyQuantity));
        ValidateRequiredProperty(nameof(EnergyUnit));
    }
}