using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;
using Spdx3.Tests.Model.Core.NonElements;
using Spdx3.Tests.Model.Extension;

namespace Spdx3.Tests.Model.Core.Elements;

public class ElementTest : BaseModelTestClass
{
    [Fact]
    public void Requires_CreationInfo_Parameter()
    {
        // Act - note, no parameter
        var exception = Record.Exception(() => TestFactory.New<TestElement>());
        Assert.NotNull(exception);
        Assert.Equal(
            "Creating instances of TestElement requires using the New(CreationInfo creationInfo) form",
            exception.Message);
    }

    [Fact]
    public void BrandNew_Element_IsValid()
    {
        // Arrange
        var element = TestFactory.New<TestElement>(TestCreationInfo);

        // Assert
        Assert.Null(Record.Exception(() => element.Validate()));
    }

    [Fact]
    public void BrandNew_Element_SerializesProperly()
    {
        // Arrange
        var element = TestFactory.New<TestElement>(TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "TestElement",
                                  "spdxId": "urn:TestElement:402"
                                }
                                """;

        // Act
        var json = element.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Element_SerializesProperly()
    {
        // Arrange
        var element = TestFactory.New<TestElement>(TestCreationInfo);
        element.Comment = "TestComment";
        element.Description = "TestDescription";
        element.Extension.Add(TestFactory.New<TestExtension>());
        element.ExternalIdentifier.Add(
            TestFactory.New<ExternalIdentifier>(ExternalIdentifierType.email, "example@example.com"));
        element.ExternalRef.Add(TestFactory.New<ExternalRef>(ExternalRefType.altDownloadLocation));
        element.Name = "TestName";
        element.Summary = "TestSummary";
        element.VerifiedUsing.Add(TestFactory.New<TestIntegrityMethod>());


        const string expected = """
                                {
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "extension": [
                                    "urn:TestExtension:40f"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:41c"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:429"
                                  ],
                                  "name": "TestName",
                                  "summary": "TestSummary",
                                  "verifiedUsing": [
                                    "urn:TestIntegrityMethod:436"
                                  ],
                                  "type": "TestElement",
                                  "spdxId": "urn:TestElement:402"
                                }
                                """;

        // Act
        var json = element.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void TypeNew_Element_FailsValidation_Empty_SpdxId()
    {
        // Arrange
        var element = TestFactory.New<TestElement>(TestCreationInfo);
        element.SpdxId = string.Empty;

        // Act
        var exception = Record.Exception(() => element.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object TestElement, property SpdxId: Field is empty", exception.Message);
    }


    [Fact]
    public void TypeNew_Element_FailsValidation_Empty_Type()
    {
        // Arrange
        var element = TestFactory.New<TestElement>(TestCreationInfo);
        element.Type = string.Empty;

        // Act
        var exception = Record.Exception(() => element.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object TestElement, property Type: Field is empty", exception.Message);
    }
}