using Spdx3.Model.AI.Classes;
using Spdx3.Model.AI.Enums;

namespace Spdx3.Tests.Model.AI.Classes;

public class EnergyConsumptionDescriptionTest : BaseModelTestClass
{
    [Fact]
    public void EnergyConsumptionDescription_MinimalObject_Serializes()
    {
        // Arrange
        var energyConsumptionDescription = new EnergyConsumptionDescription(TestCatalog, 5.5, EnergyUnitType.kilowattHour);
        const string expected = """
                                {
                                  "ai_energyQuantity": 5.5,
                                  "ai_energyUnit": "kilowattHour",
                                  "type": "ai_EnergyConsumptionDescription",
                                  "spdxId": "urn:EnergyConsumptionDescription:402"
                                }
                                """;
        
        // Act
        var json = ToJson(energyConsumptionDescription);
        
        // Assert
        Assert.Equal(expected, json);
    }
}