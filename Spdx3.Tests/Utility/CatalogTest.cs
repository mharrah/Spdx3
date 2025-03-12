using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Utility;

public class CatalogTest
{
    [Fact]
    public void SpdxIdFactory_NewGeneratesId()
    {
        var spdxIdFactory = new Catalog();
        var id = spdxIdFactory.NewId(typeof(TestBaseModelClass));
        Assert.NotNull(id);
        Assert.Matches("urn:TestBaseModelClass:[0-9a-f]{3}", id);
    }

    [Fact]
    public void SpdxIdFactory_NewGeneratesAnother()
    {
        var spdxIdFactory = new Catalog();
        var id = spdxIdFactory.NewId(typeof(string));
        Assert.NotNull(id);
        Assert.Matches("urn:String:[0-9a-f]{3}", id);
    }

    [Fact]
    public void SpdxIdFactory_NewGeneratesDifferentIdsEachTime()
    {
        var spdxIdFactory = new Catalog();
        var id1 = spdxIdFactory.NewId(typeof(TestBaseModelClass));
        var id2 = spdxIdFactory.NewId(typeof(TestBaseModelClass));
        Assert.NotEqual(id1, id2);
    }
}