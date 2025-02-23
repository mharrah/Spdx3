using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Elements;

public class BomTest : BaseElementTestClass
{
        [Fact]
    public void BrandNew_Bom_SerializesProperly()
    {
        // Arrange
        var bom = TestFactory.New<Bom>(this.TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Bom",
                                  "spdxId": "urn:Bom:402"
                                }
                                """;
        
        // Act
        var json = bom.ToJson();
        
        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Bom_SerializesProperly()
    {
        // Arrange
        var bom = TestFactory.New<Bom>(this.TestCreationInfo);
        bom.Comment = "TestComment";
        bom.Context.Add("Some context");
        bom.Context.Add("More context");
        bom.Description = "TestDescription";
        bom.ElementRef.Add("testRef1");
        bom.ElementRef.Add("testRef2");
        bom.Name = "TestName";
        bom.RootElementRef.Add("testref");
        bom.ProfileConformance.Add(ProfileIdentifierType.security);
        
        const string expected = """
                                {
                                  "context": [
                                    "Some context",
                                    "More context"
                                  ],
                                  "profileConformance": [
                                    "security"
                                  ],
                                  "rootElement": [
                                    "testref"
                                  ],
                                  "element": [
                                    "testRef1",
                                    "testRef2"
                                  ],
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "type": "Bom",
                                  "spdxId": "urn:Bom:402"
                                }
                                """;
        
        // Act
        var json = bom.ToJson();
        
        // Assert
        Assert.Equal(expected, json);
    }

    
}