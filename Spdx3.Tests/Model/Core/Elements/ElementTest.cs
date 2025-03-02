using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;
using Spdx3.Tests.Model.Core.NonElements;
using Spdx3.Tests.Model.Extension;

namespace Spdx3.Tests.Model.Core.Elements;

public class ElementTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_Element_IsValid()
    {
        // Arrange
        var element = new TestElement(TestSpdxIdFactory, TestCreationInfo);

        // Assert
        Assert.Null(Record.Exception(() => element.Validate()));
    }

    [Fact]
    public void BrandNew_Element_SerializesProperly()
    {
        // Arrange
        var element = new TestElement(TestSpdxIdFactory, TestCreationInfo);
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
        var element = new TestElement(TestSpdxIdFactory, TestCreationInfo)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary"
        };
        element.Extension.Add(new TestExtension(TestSpdxIdFactory));
        element.ExternalIdentifier.Add(
            new ExternalIdentifier(TestSpdxIdFactory, ExternalIdentifierType.email, "example@example.com"));
        element.ExternalRef.Add(new ExternalRef(TestSpdxIdFactory, ExternalRefType.altDownloadLocation));
        element.VerifiedUsing.Add(new TestIntegrityMethod(TestSpdxIdFactory));


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
    public void TypeNew_Element_FailsValidation_Empty_Type()
    {
        // Arrange
        var element = new TestElement(TestSpdxIdFactory, TestCreationInfo)
        {
            Type = string.Empty
        };

        // Act
        var exception = Record.Exception(() => element.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object TestElement, property Type: Field is empty", exception.Message);
    }
}