using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class ElementTest : BaseModelTest
{
    [Fact]
    public void BrandNew_Element_IsValid()
    {
        // Arrange
        var element = new ElementConcreteTestFixture(TestCatalog, TestCreationInfo);

        // Assert
        Assert.Null(Record.Exception(() => element.Validate()));
    }

    [Fact]
    public void BrandNew_Element_SerializesProperly()
    {
        // Arrange
        var element = new ElementConcreteTestFixture(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "ElementConcreteTestFixture",
                                  "spdxId": "urn:ElementConcreteTestFixture:40f"
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
        var element = new ElementConcreteTestFixture(TestCatalog, TestCreationInfo)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary"
        };
        element.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        element.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email,
            "example@example.com"));
        element.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.altDownloadLocation));
        element.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));

        const string expected = """
                                {
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "extension": [
                                    "urn:ExtensionConcreteTestFixture:41c"
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
                                    "urn:IntegrityMethodConcreteTestFixture:443"
                                  ],
                                  "type": "ElementConcreteTestFixture",
                                  "spdxId": "urn:ElementConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(element);

        // Assert
        Assert.Equal(expected, json);
        Assert.Equal(7, TestCatalog.Items.Count);
    }


    [Fact]
    public void TestElement_DeserializesAsExpected()
    {
        const string json = """
                            {
                              "creationInfo": "urn:CreationInfo:3f5",
                              "type": "ElementConcreteTestFixture",
                              "spdxId": "urn:ElementConcreteTestFixture:402"
                            }
                            """;

        var testElement = FromJson<ElementConcreteTestFixture>(json);
        Assert.NotNull(testElement);
        Assert.IsType<ElementConcreteTestFixture>(testElement);
        Assert.Equal("ElementConcreteTestFixture", testElement.Type);
        Assert.Equal(new Uri("urn:ElementConcreteTestFixture:402"), testElement.SpdxId);
        Assert.NotNull(testElement.CreationInfo);
        Assert.Equal(new Uri("urn:CreationInfo:3f5"), testElement.CreationInfo.SpdxId);
        Assert.Equal("CreationInfo", testElement.CreationInfo.Type);
    }

    [Fact]
    public void TypeNew_Element_FailsValidation_Empty_Type()
    {
        // Arrange
        var element = new ElementConcreteTestFixture(TestCatalog, TestCreationInfo)
        {
            Type = string.Empty
        };

        // Act
        var exception = Record.Exception(() => element.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object ElementConcreteTestFixture, property Type: String field is empty", exception.Message);
    }
}