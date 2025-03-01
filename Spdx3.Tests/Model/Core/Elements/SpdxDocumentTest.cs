using Spdx3.Model.Core.Elements;

namespace Spdx3.Tests.Model.Core.Elements;

public class SpdxDocumentTest : BaseModelTestClass
{
    [Fact]
    public void Requires_CreationInfo_Parameter()
    {
        // Act - note, no parameter
        var exception = Record.Exception(() => TestFactory.New<SpdxDocument>());
        Assert.NotNull(exception);
        Assert.Equal(
            "Creating instances of SpdxDocument requires using the New(CreationInfo creationInfo) form",
            exception.Message);
    }

    [Fact]
    public void SpdxDocument_NewElement_ShouldValidate()
    {
        var spdxDocument = TestFactory.New<SpdxDocument>(TestCreationInfo);
        var exception = Record.Exception(() => spdxDocument.Validate());
        Assert.Null(exception);
    }
}