using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Utility;

public class CatalogTest
{
    [Fact]
    public void SpdxIdFactory_NewGeneratesId()
    {
        var spdxIdFactory = new Catalog();
        var id = spdxIdFactory.NewId(typeof(BaseModelClassConcreteTestFixture));
        Assert.NotNull(id);
        Assert.Matches("urn:BaseModelClassConcreteTestFixture:[0-9a-f]{3}", id.ToString());
    }

    [Fact]
    public void SpdxIdFactory_NewGeneratesAnother()
    {
        var spdxIdFactory = new Catalog();
        var id = spdxIdFactory.NewId(typeof(string));
        Assert.NotNull(id);
        Assert.Matches("urn:String:[0-9a-f]{3}", id.ToString());
    }

    [Fact]
    public void SpdxIdFactory_NewGeneratesDifferentIdsEachTime()
    {
        var spdxIdFactory = new Catalog();
        var id1 = spdxIdFactory.NewId(typeof(BaseModelClassConcreteTestFixture));
        var id2 = spdxIdFactory.NewId(typeof(BaseModelClassConcreteTestFixture));
        Assert.NotEqual(id1, id2);
    }
}