using Spdx3.Utility;

namespace Spdx3.Tests.Utility;

public class SpdxIdFactoryTest 
{
    [Fact]
    public void SpdxIdFactory_NewGeneratesId()
    {
        var spdxIdFactory = new SpdxIdFactory();
        var id = spdxIdFactory.New("test");
        Assert.NotNull(id);
        Assert.Matches("urn:test:[0-9a-f]{3}", id);
    }

    [Fact]
    public void SpdxIdFactory_NewGeneratesAnother()
    {
        var spdxIdFactory = new SpdxIdFactory();
        var id = spdxIdFactory.New("another");
        Assert.NotNull(id);
        Assert.Matches("urn:another:[0-9a-f]{3}", id);
    }

    [Fact]
    public void SpdxIdFactory_NewGeneratesDifferentIdsEachTime()
    {
        var spdxIdFactory = new SpdxIdFactory();
        var id1 = spdxIdFactory.New("test");
        var id2 = spdxIdFactory.New("test");
        Assert.NotEqual(id1, id2);
    }
}