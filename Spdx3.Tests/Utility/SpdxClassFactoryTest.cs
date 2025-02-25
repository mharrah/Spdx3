using Spdx3.Model.Core.NonElements;
using Spdx3.Tests.Model.Core.Elements;
using Spdx3.Utility;

namespace Spdx3.Tests.Utility;

/// <summary>
///     Basic, direct test of the SpdxClassFactory.  Gets used (but not tested, per se) in nearly all the other tests,
///     so not doing a lot here.
/// </summary>
public class SpdxClassFactoryTest
{
    [Fact]
    public void SpdxClassFactory_CanMakeCreationInfo()
    {
        // Arrange
        var factory = new SpdxClassFactory();
        const string firstSpdxIdNumber = "3f5";

        // Act
        var creationInfo = factory.New<CreationInfo>();

        // Assert
        Assert.NotNull(creationInfo);
        Assert.IsType<CreationInfo>(creationInfo);
        Assert.Equal("CreationInfo", creationInfo.Type);
        Assert.Equal($"urn:CreationInfo:{firstSpdxIdNumber}", creationInfo.SpdxId);
    }

    [Fact]
    public void SpdxClassFactory_ObjectsFromDifferentFactories_HaveSameSpdxIds()
    {
        // Arrange
        var factory1 = new SpdxClassFactory();
        var factory2 = new SpdxClassFactory();
        const string firstSpdxId = "urn:CreationInfo:3f5";

        // Act
        var creationInfo1 = factory1.New<CreationInfo>();
        var creationInfo2 = factory2.New<CreationInfo>();

        // Assert
        Assert.Equal(creationInfo1.SpdxId, creationInfo2.SpdxId);

        Assert.Single(factory1.EverythingProduced);
        Assert.Contains(creationInfo1, factory1.EverythingProduced);
        Assert.Equal(firstSpdxId, creationInfo1.SpdxId);

        Assert.Single(factory2.EverythingProduced);
        Assert.Contains(creationInfo2, factory2.EverythingProduced);
        Assert.Equal(firstSpdxId, creationInfo2.SpdxId);
    }


    [Fact]
    public void SpdxClassFactory_ObjectsFromSameFactory_HaveDifferentSpdxIds()
    {
        // Arrange
        var factory = new SpdxClassFactory();
        const string firstSpdxId = "urn:CreationInfo:3f5";

        // Act
        var creationInfo1 = factory.New<CreationInfo>();
        var creationInfo2 = factory.New<CreationInfo>();

        // Assert
        Assert.NotEqual(creationInfo1.SpdxId, creationInfo2.SpdxId);

        Assert.Equal(2, factory.EverythingProduced.Count);

        Assert.Contains(creationInfo1, factory.EverythingProduced);
        Assert.Equal(firstSpdxId, creationInfo1.SpdxId);

        Assert.Contains(creationInfo2, factory.EverythingProduced);
        Assert.NotEqual(firstSpdxId, creationInfo2.SpdxId);
    }


    [Fact]
    public void SpdxClassFactory_Throws_WhenMakingElement_WithoutCreationInfo()
    {
        // Arrange
        var factory = new SpdxClassFactory();

        // Act
        var exception = Record.Exception(() => factory.New<TestElement>());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Parameter of type CreationInfo required when creating subclasses of Element", exception.Message);
    }
}