using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Utility;

public class SpdxCatalogTest
{
    [Fact]
    public void SpdxIdFactory_NewGeneratesId()
    {
        var spdxIdFactory = new SpdxCatalog();
        var id = spdxIdFactory.NewId(typeof(TestBaseSpdxClass));
        Assert.NotNull(id);
        Assert.Matches("urn:TestBaseSpdxClass:[0-9a-f]{3}", id);
    }

    [Fact]
    public void SpdxIdFactory_NewGeneratesAnother()
    {
        var spdxIdFactory = new SpdxCatalog();
        var id = spdxIdFactory.NewId(typeof(string));
        Assert.NotNull(id);
        Assert.Matches("urn:String:[0-9a-f]{3}", id);
    }

    [Fact]
    public void SpdxIdFactory_NewGeneratesDifferentIdsEachTime()
    {
        var spdxIdFactory = new SpdxCatalog();
        var id1 = spdxIdFactory.NewId(typeof(TestBaseSpdxClass));
        var id2 = spdxIdFactory.NewId(typeof(TestBaseSpdxClass));
        Assert.NotEqual(id1, id2);
    }
}