using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class ElementTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_Element_IsValid()
    {
        // Arrange
        var element = new TestElement(TestCatalog, TestCreationInfo);

        // Assert
        Assert.Null(Record.Exception(() => element.Validate()));
    }

    [Fact]
    public void BrandNew_Element_SerializesProperly()
    {
        // Arrange
        var element = new TestElement(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "TestElement",
                                  "spdxId": "urn:TestElement:40f"
                                }
                                """;

        // Act
        var json = ToJson(element);

        // Assert
        Assert.Equal(expected, json);
        Assert.Equal(3, TestCatalog.Items.Count);
    }

    [Fact]
    public void FullyPopulated_Element_SerializesProperly()
    {
        // Arrange
        var element = new TestElement(TestCatalog, TestCreationInfo)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary"
        };
        element.Extension.Add(new TestExtension(TestCatalog));
        element.ExternalIdentifier.Add(
            new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));
        element.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.altDownloadLocation));
        element.VerifiedUsing.Add(new TestIntegrityMethod(TestCatalog));


        const string expected = """
                                {
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "extension": [
                                    "urn:TestExtension:41c"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:429"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:436"
                                  ],
                                  "name": "TestName",
                                  "summary": "TestSummary",
                                  "verifiedUsing": [
                                    "urn:TestIntegrityMethod:443"
                                  ],
                                  "type": "TestElement",
                                  "spdxId": "urn:TestElement:40f"
                                }
                                """;

        // Act
        var json = ToJson(element);

        // Assert
        Assert.Equal(expected, json);
        Assert.Equal(7, TestCatalog.Items.Count);
    }

    [Fact]
    public void TypeNew_Element_FailsValidation_Empty_Type()
    {
        // Arrange
        var element = new TestElement(TestCatalog, TestCreationInfo)
        {
            Type = string.Empty
        };

        // Act
        var exception = Record.Exception(() => element.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object TestElement, property Type: String field is empty", exception.Message);
    }


    [Fact]
    public void TestElement_DeserializesAsExpected()
    {
        const string json = """
                            {
                              "creationInfo": "urn:CreationInfo:3f5",
                              "type": "TestElement",
                              "spdxId": "urn:TestElement:402"
                            }
                            """;

        var testElement = FromJson<TestElement>(json);
        Assert.NotNull(testElement);
        Assert.IsType<TestElement>(testElement);
        Assert.Equal("TestElement", testElement.Type);
        Assert.Equal(new Uri("urn:TestElement:402"), testElement.SpdxId);
        Assert.NotNull(testElement.CreationInfo);
        Assert.Equal(new Uri("urn:CreationInfo:3f5"), testElement.CreationInfo.SpdxId);
        Assert.Equal("CreationInfo", testElement.CreationInfo.Type);
    }
}