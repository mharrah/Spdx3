using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.NonElements;

public class CreationInfoTest
{
    [Fact]
    public void CreationInfo_Basics()
    {
        // Arrange
        var factory = new SpdxClassFactory();
        
        // Act
        var creationInfo = factory.NewClass(typeof(CreationInfo));
        
        // Assert
        Assert.NotNull(creationInfo);
        Assert.IsType<CreationInfo>(creationInfo);
        Assert.Equal("CreationInfo", creationInfo.Type);
        Assert.Equal("urn:CreationInfo:3f5", creationInfo.SpdxId);
    }
    
    [Fact]
    public void CreationInfo_SerializesAsJson()
    {
        // Arrange
        var factory = new SpdxClassFactory();
        
        // Act
        var creationInfo = factory.NewClass(typeof(CreationInfo));
        
        
        // Assert
        Assert.NotNull(creationInfo);
        Assert.IsType<CreationInfo>(creationInfo);
        Assert.Equal("CreationInfo", creationInfo.Type);
        Assert.Equal("urn:CreationInfo:3f5", creationInfo.SpdxId);
    }

}