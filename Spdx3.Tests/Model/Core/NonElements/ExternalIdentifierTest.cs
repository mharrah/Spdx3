using Spdx3.Model.Core.NonElements;
using Spdx3.Tests.Model.Core.Elements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.NonElements;

public class ExternalIdentifierTest : BaseSpdxClassTest
{
    [Fact]
    public void ExternalIdentifier_Basics()
    {
        // Arrange
        var factory = new SpdxClassFactory();
        
        // Act
        var externalIdentifier = factory.New<ExternalIdentifier>();
        
        // Assert
        Assert.NotNull(externalIdentifier);
        Assert.IsType<ExternalIdentifier>(externalIdentifier);
        Assert.Equal("ExternalIdentifier", externalIdentifier.Type);
        Assert.Equal("urn:ExternalIdentifier:3f5", externalIdentifier.SpdxId);
    }
    
    [Fact]
    public void ExternalIdentifier_FullyPopulated_SerializesAsJson()
    {
        // Arrange
        var externalIdentifier = TestFactory.New<ExternalIdentifier>();
        externalIdentifier.Comment = "Test comment";
        
        var expected = """
                       {
                         "comment": "Test comment",
                         "type": "ExternalIdentifier",
                         "spdxId": "urn:ExternalIdentifier:3f5"
                       }
                       """;
        
        // Act
        var json = externalIdentifier.ToJson();        
        
        // Assert
        Assert.Equal(expected, json);
    }

}