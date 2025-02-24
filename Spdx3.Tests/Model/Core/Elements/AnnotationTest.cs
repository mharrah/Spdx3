using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Elements;

public class AnnotationTest : BaseElementTestClass
{
    [Fact]
    public void Requires_CreationInfo_Parameter()
    {
        // Act - note, no parameter
        var exception = Record.Exception(() => TestFactory.New<Annotation>());
        Assert.NotNull(exception);
        Assert.Equal(
            "Parameter of type CreationInfo required when creating subclasses of Element",
            exception.Message);
    }
    
    [Fact]
    public void Requires_AnnotationType_Parameter()
    {
        // Act - note, no AnnotationType parameter
        var exception = Record.Exception(() => TestFactory.New<Annotation>(TestCreationInfo));
        Assert.NotNull(exception);
        Assert.Equal(
            "Parameters of type CreationInfo, AnnotationType, and Element are required when "+
            "creating instances of Annotation or its subclasses",
            exception.Message);
    }
    
    [Fact]
    public void BrandNew_Element_HasRequiredFields()
    {
        // Arrange
        var subject = TestFactory.New<TestElement>(TestCreationInfo);
        var annotation = TestFactory.New<Annotation>(this.TestCreationInfo, AnnotationType.review, subject);
        
        // Assert
        Assert.Null(Record.Exception(() => annotation.Validate()));
        Assert.Equal("Annotation", annotation.Type);
    }

    [Fact]
    public void BrandNew_Element_SerializesProperly()
    {
        // Arrange
        var subject = TestFactory.New<TestElement>(TestCreationInfo);
        var annotation = TestFactory.New<Annotation>(this.TestCreationInfo,  AnnotationType.review, subject);
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
        var annotation = TestFactory.New<Annotation>(this.TestCreationInfo, AnnotationType.other, subject );
        annotation.Comment = "TestComment";
        annotation.Description = "TestDescription";
        annotation.Name = "TestName";
        annotation.Statement = "TestStatement";
        annotation.MediaType = "TestMediaType";
        annotation.Summary = "TestSummary";
        annotation.SubjectRef = "testSubjectRef";
        annotation.AnnotationType = AnnotationType.review;
        
        const string expected = """
                                {
                                  "subject": "testSubjectRef",
                                  "annotationType": "review",
                                  "statement": "TestStatement",
                                  "mediaType": "TestMediaType",
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "summary": "TestSummary",
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
        var annotation = TestFactory.New<Annotation>(this.TestCreationInfo, AnnotationType.other, subject);
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
        var annotation = TestFactory.New<Annotation>(this.TestCreationInfo, AnnotationType.review, subject);
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