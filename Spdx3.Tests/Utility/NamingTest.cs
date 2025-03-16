using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Extension.Classes;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Utility;
using File = Spdx3.Model.Software.Classes.File;

namespace Spdx3.Tests.Utility;

public class NamingTest
{
    [Fact]
    public void SpdxUtility_SpdxTypeForClass_ShouldReturnSpdxTypes()
    {
        Assert.Equal("Annotation", Naming.SpdxTypeForClass(typeof(Annotation)));
        Assert.Equal("simplelicensing_LicenseExpression", Naming.SpdxTypeForClass(typeof(LicenseExpression)));
        Assert.Equal("software_File", Naming.SpdxTypeForClass(typeof(File)));
        Assert.Equal("extension_CdxPropertiesExtension", Naming.SpdxTypeForClass(typeof(CdxPropertiesExtension)));
    }

    [Fact]
    public void SpdxUtility_SpdxTypeForClass_ShouldThrowForNonSpdxTypes()
    {
        var ex = Record.Exception(() => Naming.SpdxTypeForClass(typeof(string)));

        Assert.NotNull(ex);
        Assert.IsType<Spdx3Exception>(ex);
        Assert.Equal("Unable to determine SPDX3 node type value for System.String", ex.Message);
    }


    [Fact]
    public void SpdxUtility_SpdxTypeForClass_ShouldThrowForTypeInEmptyNamespace()
    {
        var t = typeof(TestClassWithEmptyNamespace);
        var ex = Record.Exception(() => Naming.SpdxTypeForClass(t));

        Assert.NotNull(ex);
        Assert.IsType<Spdx3Exception>(ex);
        Assert.Equal("Unable to determine SPDX3 node type value for TestClassWithEmptyNamespace", ex.Message);
    }
}