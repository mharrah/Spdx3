using Spdx3.Model.AI.Classes;
using Spdx3.Model.AI.Enums;

namespace Spdx3.Tests.Model.AI.Classes;

public class EnergyConsumptionTest : BaseModelTest
{
    [Fact]
    public void EnergyConsumption_MinimalObject_Serializes()
    {
        // Arrange
        var energyConsumption = new EnergyConsumption(TestCatalog);
        const string expected = """
                                {
                                  "type": "ai_EnergyConsumption",
                                  "spdxId": "urn:EnergyConsumption:40f"
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
        energyConsumption.FinetuningEnergyConsumption.Add(
            new EnergyConsumptionDescription(TestCatalog, 1.2, EnergyUnitType.kilowattHour));
        energyConsumption.InferenceEnergyConsumption.Add(
            new EnergyConsumptionDescription(TestCatalog, 4.4, EnergyUnitType.megajoule));
        energyConsumption.InferenceEnergyConsumption.Add(
            new EnergyConsumptionDescription(TestCatalog, 6.1, EnergyUnitType.other));
        energyConsumption.TrainingEnergyConsumption.Add(
            new EnergyConsumptionDescription(TestCatalog, 3.8, EnergyUnitType.megajoule));
        const string expected = """
                                {
                                  "ai_finetuningEnergyConsumption": [
                                    "urn:EnergyConsumptionDescription:41c"
                                  ],
                                  "ai_inferenceEnergyConsumption": [
                                    "urn:EnergyConsumptionDescription:429",
                                    "urn:EnergyConsumptionDescription:436"
                                  ],
                                  "ai_trainingEnergyConsumption": [
                                    "urn:EnergyConsumptionDescription:443"
                                  ],
                                  "type": "ai_EnergyConsumption",
                                  "spdxId": "urn:EnergyConsumption:40f"
                                }
                                """;

        // Act
        var json = ToJson(energyConsumption);

        // Assert
        Assert.Equal(expected, json);
    }
}