using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;
using Spdx3.Tests.Model.Core.NonElements;
using Spdx3.Tests.Model.Extension;

namespace Spdx3.Tests.Model.Core.Elements;

public class AnnotationTest : BaseModelTestClass
{
    [Fact]
    public void Requires_AnnotationType_Parameter()
    {
        // Act - note, no AnnotationType parameter
        var exception = Record.Exception(() => TestFactory.New<Annotation>(TestCreationInfo));
        Assert.NotNull(exception);
        Assert.Equal(
            "Creating instances of Annotation requires using the New(CreationInfo creationInfo, AnnotationType annotationType, Element subject) form",
            exception.Message);
    }

    [Fact]
    public void BrandNew_Element_HasRequiredFields()
    {
        // Arrange
        var subject = TestFactory.New<TestElement>(TestCreationInfo);
        var annotation = TestFactory.New<Annotation>(TestCreationInfo, AnnotationType.review, subject);

        // Assert
        Assert.Null(Record.Exception(() => annotation.Validate()));
        Assert.Equal("Annotation", annotation.Type);
    }

    [Fact]
    public void BrandNew_Element_SerializesProperly()
    {
        // Arrange
        var subject = TestFactory.New<TestElement>(TestCreationInfo);
        var annotation = TestFactory.New<Annotation>(TestCreationInfo, AnnotationType.review, subject);
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
        var subject = TestFactory.New<TestElement>(TestCreationInfo);
        var annotation = TestFactory.New<Annotation>(TestCreationInfo, AnnotationType.other, subject);
        annotation.Comment = "TestComment";
        annotation.Description = "TestDescription";
        annotation.Extension.Add(TestFactory.New<TestExtension>());
        annotation.ExternalIdentifier.Add(TestFactory.New<ExternalIdentifier>());
        annotation.ExternalRef.Add(TestFactory.New<ExternalRef>());
        annotation.Name = "TestName";
        annotation.Statement = "TestStatement";
        annotation.MediaType = "TestMediaType";
        annotation.Summary = "TestSummary";
        annotation.Subject = TestFactory.New<TestElement>(TestCreationInfo);
        annotation.AnnotationType = AnnotationType.review;
        annotation.VerifiedUsing.Add(TestFactory.New<TestIntegrityMethod>());

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
    public void TypeNew_Element_FailsValidation_Empty_SpdxId()
    {
        // Arrange
        var subject = TestFactory.New<TestElement>(TestCreationInfo);
        var annotation = TestFactory.New<Annotation>(TestCreationInfo, AnnotationType.other, subject);
        annotation.SpdxId = string.Empty;

        // Act
        var exception = Record.Exception(() => annotation.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object Annotation, property SpdxId: Field is empty", exception.Message);
    }


    [Fact]
    public void TypeNew_Element_FailsValidation_Empty_Type()
    {
        // Arrange
        var subject = TestFactory.New<TestElement>(TestCreationInfo);
        var annotation = TestFactory.New<Annotation>(TestCreationInfo, AnnotationType.review, subject);
        annotation.Type = string.Empty;

        // Act
        var exception = Record.Exception(() => annotation.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object Annotation, property Type: Field is empty", exception.Message);
    }

    [Fact]
    public void Annotation_FailsValidation_MissingAnnotationType()
    {
        // Arrange
        var subject = TestFactory.New<TestElement>(TestCreationInfo);
        var annotation = TestFactory.New<Annotation>(TestCreationInfo, AnnotationType.other, subject);
        annotation.AnnotationType = null;

        // Act
        var exception = Record.Exception(() => annotation.Validate());
        Assert.NotNull(exception);
        Assert.Equal("Object Annotation, property AnnotationType: Field is required", exception.Message);
    }
}