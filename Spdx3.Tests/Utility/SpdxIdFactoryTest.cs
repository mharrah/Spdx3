using Spdx3.Tests.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Utility;

public class SpdxIdFactoryTest
{
    [Fact]
    public void SpdxIdFactory_NewGeneratesId()
    {
        var spdxIdFactory = new SpdxIdFactory();
        var id = spdxIdFactory.New(typeof(TestBaseSpdxClass));
        Assert.NotNull(id);
        Assert.Matches("urn:TestBaseSpdxClass:[0-9a-f]{3}", id);
    }

    [Fact]
    public void SpdxIdFactory_NewGeneratesAnother()
    {
        var spdxIdFactory = new SpdxIdFactory();
        var id = spdxIdFactory.New(typeof(string));
        Assert.NotNull(id);
        Assert.Matches("urn:String:[0-9a-f]{3}", id);
    }

    [Fact]
    public void SpdxIdFactory_NewGeneratesDifferentIdsEachTime()
    {
        var spdxIdFactory = new SpdxIdFactory();
        var id1 = spdxIdFactory.New(typeof(TestBaseSpdxClass));
        var id2 = spdxIdFactory.New(typeof(TestBaseSpdxClass));
        Assert.NotEqual(id1, id2);
    }
}