using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;
using Spdx3.Tests.Model.Core.NonElements;
using Spdx3.Tests.Model.Extension;

namespace Spdx3.Tests.Model.Core.Elements;

public class AnnotationTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_Element_HasRequiredFields()
    {
        // Arrange
        var subject = new TestElement(TestSpdxIdFactory, TestCreationInfo);
        var annotation = new Annotation(TestSpdxIdFactory, TestCreationInfo, AnnotationType.review, subject);

        // Assert
        Assert.Null(Record.Exception(() => annotation.Validate()));
        Assert.Equal("Annotation", annotation.Type);
    }

    [Fact]
    public void BrandNew_Element_SerializesProperly()
    {
        // Arrange
        var subject = new TestElement(TestSpdxIdFactory, TestCreationInfo);
        var annotation = new Annotation(TestSpdxIdFactory, TestCreationInfo, AnnotationType.review, subject);
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
        var json = annotation.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Element_SerializesProperly()
    {
        // Arrange
        var subject = new TestElement(TestSpdxIdFactory, TestCreationInfo);
        var annotation = new Annotation(TestSpdxIdFactory, TestCreationInfo, AnnotationType.other, subject);
        annotation.Comment = "TestComment";
        annotation.Description = "TestDescription";
        annotation.Extension.Add(new TestExtension(TestSpdxIdFactory));
        annotation.ExternalIdentifier.Add(
            new ExternalIdentifier(TestSpdxIdFactory, ExternalIdentifierType.email, "example@example.com"));
        annotation.ExternalRef.Add(new ExternalRef(TestSpdxIdFactory, ExternalRefType.other));
        annotation.Name = "TestName";
        annotation.Statement = "TestStatement";
        annotation.MediaType = "TestMediaType";
        annotation.Summary = "TestSummary";
        annotation.Subject = new TestElement(TestSpdxIdFactory, TestCreationInfo);
        annotation.AnnotationType = AnnotationType.review;
        annotation.VerifiedUsing.Add(new TestIntegrityMethod(TestSpdxIdFactory));

        const string expected = """
                                {
                                  "subject": "urn:TestElement:443",
                                  "annotationType": "review",
                                  "statement": "TestStatement",
                                  "mediaType": "TestMediaType",
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
                                    "urn:TestIntegrityMethod:450"
                                  ],
                                  "type": "Annotation",
                                  "spdxId": "urn:Annotation:40f"
                                }
                                """;

        // Act
        var json = annotation.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void TypeNew_Element_FailsValidation_Empty_Type()
    {
        // Arrange
        var subject = new TestElement(TestSpdxIdFactory, TestCreationInfo);
        var annotation = new Annotation(TestSpdxIdFactory, TestCreationInfo, AnnotationType.review, subject);
        annotation.Type = string.Empty;

        // Act
        var exception = Record.Exception(() => annotation.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object Annotation, property Type: Field is empty", exception.Message);
    }
}