using Spdx3.Tests.Model;
using Spdx3.Utility;

namespace Spdx3.Tests.Utility;

public class SpdxIdFactoryTest : BaseElementTestClass
{

    [Fact]
    public void SpdxIdFactory_NewGeneratesId()
    {
        ISpdxIdFactory spdxIdFactory = new SpdxIdFactory();
        var id = spdxIdFactory.New("test");
        Assert.NotNull(id);
        Assert.Matches("urn:test:[0-9a-f]{3}", id);
    }

    [Fact]
    public void SpdxIdFactory_NewGeneratesDifferentIdsEachTime()
    {
        ISpdxIdFactory spdxIdFactory = new SpdxIdFactory();
        var id1 = spdxIdFactory.New("test");
        var id2 = spdxIdFactory.New("test");
        Assert.NotEqual(id1, id2);
    }

}