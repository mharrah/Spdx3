using Spdx3.Model.Core.Elements;

namespace Spdx3.Tests.Model.Core.Elements;

public class SpdxDocumentTest : BaseModelTestClass
{
    [Fact]
    public void SpdxDocument_NewElement_ShouldValidate()
    {
        var spdxDocument = new SpdxDocument(TestSpdxIdFactory, TestCreationInfo);
        var exception = Record.Exception(() => spdxDocument.Validate());
        Assert.Null(exception);
    }
}