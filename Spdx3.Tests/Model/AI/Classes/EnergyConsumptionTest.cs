using Spdx3.Model.AI.Classes;
using Spdx3.Model.AI.Enums;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Software.Enums;

namespace Spdx3.Tests.Model.AI.Classes;

public class EnergyConsumptionTest : BaseModelTestClass
{
    [Fact]
    public void EnergyConsumption_MinimalObject_Serializes()
    {
        // Arrange
        var energyConsumption = new EnergyConsumption(TestCatalog);
        const string expected = """
                                {
                                  "type": "ai_EnergyConsumption",
                                  "spdxId": "urn:EnergyConsumption:402"
                                }
                                """;
        
        // Act
        var json = ToJson(energyConsumption);
        
        // Assert
        Assert.Equal(expected, json);
    }
    
    [Fact]
    public void EnergyConsumption_PartialObject_Serializes()
    {
        // Arrange
        var energyConsumption = new EnergyConsumption(TestCatalog);
        energyConsumption.FinetuningEnergyConsumption.Add(new EnergyConsumptionDescription(TestCatalog, 1.2, EnergyUnitType.kilowattHour));
        energyConsumption.InferenceEnergyConsumption.Add(new EnergyConsumptionDescription(TestCatalog, 4.4, EnergyUnitType.megajoule));
        energyConsumption.InferenceEnergyConsumption.Add(new EnergyConsumptionDescription(TestCatalog, 6.1, EnergyUnitType.other));
        energyConsumption.TrainingEnergyConsumption.Add(new EnergyConsumptionDescription(TestCatalog, 3.8, EnergyUnitType.megajoule));
        const string expected = """
                                {
                                  "ai_finetuningEnergyConsumption": [
                                    "urn:EnergyConsumptionDescription:40f"
                                  ],
                                  "ai_inferenceEnergyConsumption": [
                                    "urn:EnergyConsumptionDescription:41c",
                                    "urn:EnergyConsumptionDescription:429"
                                  ],
                                  "ai_trainingEnergyConsumption": [
                                    "urn:EnergyConsumptionDescription:436"
                                  ],
                                  "type": "ai_EnergyConsumption",
                                  "spdxId": "urn:EnergyConsumption:402"
                                }
                                """;
        
        // Act
        var json = ToJson(energyConsumption);
        
        // Assert
        Assert.Equal(expected, json);
    }
}