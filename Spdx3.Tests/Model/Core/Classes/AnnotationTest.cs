using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class AnnotationTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_Element_HasRequiredFields()
    {
        // Arrange
        var subject = new TestElement(TestCatalog, TestCreationInfo);
        var annotation = new Annotation(TestCatalog, TestCreationInfo, AnnotationType.review, subject);

        // Assert
        Assert.Null(Record.Exception(() => annotation.Validate()));
        Assert.Equal("Annotation", annotation.Type);
    }

    [Fact]
    public void BrandNew_Element_SerializesProperly()
    {
        // Arrange
        var subject = new TestElement(TestCatalog, TestCreationInfo);
        var annotation = new Annotation(TestCatalog, TestCreationInfo, AnnotationType.review, subject);
        const string expected = """
                                {
                                  "subject": "urn:TestElement:402",
                                  "annotationType": "review",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Annotation",
                                  "spdxId": "urn:Annotation:40f"
                                }
                                """;

        // Act
        var json = ToJson(annotation);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Element_SerializesProperly()
    {
        // Arrange
        var subject = new TestElement(TestCatalog, TestCreationInfo);
        var annotation = new Annotation(TestCatalog, TestCreationInfo, AnnotationType.other, subject)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Statement = "TestStatement",
            ContentType = "TestMediaType",
            Summary = "TestSummary",
            Subject = subject,
            AnnotationType = AnnotationType.review
        };
        annotation.Extension.Add(new TestExtension(TestCatalog));
        annotation.ExternalIdentifier.Add(
            new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));
        annotation.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.other));
        annotation.VerifiedUsing.Add(new TestIntegrityMethod(TestCatalog));

        const string expected = """
                                {
                                  "subject": "urn:TestElement:402",
                                  "annotationType": "review",
                                  "statement": "TestStatement",
                                  "contentType": "TestMediaType",
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
                                  "type": "Annotation",
                                  "spdxId": "urn:Annotation:40f"
                                }
                                """;

        // Act
        var json = ToJson(annotation);

        // Assert
        Assert.Equal(expected, json);
        Assert.Equal(7, TestCatalog.Items.Count);
    }

    [Fact]
    public void TypeNew_Element_FailsValidation_Empty_Type()
    {
        // Arrange
        var subject = new TestElement(TestCatalog, TestCreationInfo);
        var annotation = new Annotation(TestCatalog, TestCreationInfo, AnnotationType.review, subject)
        {
            Type = string.Empty
        };

        // Act
        var exception = Record.Exception(() => annotation.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object Annotation, property Type: Field is empty", exception.Message);
    }
}