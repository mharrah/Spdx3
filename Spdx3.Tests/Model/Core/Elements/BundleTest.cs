using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Elements;

public class BundleTest : BaseElementTestClass
{
        [Fact]
    public void BrandNew_Bundle_SerializesProperly()
    {
        // Arrange
        var bundle = TestFactory.New<Bundle>(this.TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Bundle",
                                  "spdxId": "urn:Bundle:402"
                                }
                                """;
        
        // Act
        var json = bundle.ToJson();
        
        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Bundle_SerializesProperly()
    {
        // Arrange
        var bundle = TestFactory.New<Bundle>(this.TestCreationInfo);
        bundle.Comment = "TestComment";
        bundle.Context.Add("Some context");
        bundle.Context.Add("More context");
        bundle.Description = "TestDescription";
        bundle.ElementRef.Add("testRef1");
        bundle.ElementRef.Add("testRef2");
        bundle.Name = "TestName";
        bundle.RootElementRef.Add("testref");
        bundle.ProfileConformance.Add(ProfileIdentifierType.security);
        
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
                                  "type": "Bundle",
                                  "spdxId": "urn:Bundle:402"
                                }
                                """;
        
        // Act
        var json = bundle.ToJson();
        
        // Assert
        Assert.Equal(expected, json);
    }

    
}