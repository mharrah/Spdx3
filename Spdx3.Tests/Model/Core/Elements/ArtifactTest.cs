namespace Spdx3.Tests.Model.Core.Elements;

public class ArtifactTest : BaseElementTestClass
{
    [Fact]
    public void Requires_CreationInfo_Parameter()
    {
        // Act - note, no parameter
        var exception = Record.Exception(() => TestFactory.New<TestArtifact>());
        Assert.NotNull(exception);
        Assert.Equal("Parameter of type CreationInfo required when creating subclasses of Element", exception.Message);
    }

    [Fact]
    public void BrandNew_Artifact_HasRequiredFields()
    {
        // Arrange
        var element = TestFactory.New<TestArtifact>(TestCreationInfo);

        // Assert
        Assert.Null(Record.Exception(() => element.Validate()));
        Assert.Equal("TestArtifact", element.Type);
    }

    [Fact]
    public void BrandNew_Artifact_SerializesProperly()
    {
        // Arrange
        var element = TestFactory.New<TestArtifact>(TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "TestArtifact",
                                  "spdxId": "urn:TestArtifact:402"
                                }
                                """;

        // Act
        var json = element.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Artifact_SerializesProperly()
    {
        // Arrange
        var element = TestFactory.New<TestArtifact>(TestCreationInfo);
        element.Comment = "TestComment";
        element.Description = "TestDescription";
        element.Name = "TestName";

        const string expected = """
                                {
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "type": "TestArtifact",
                                  "spdxId": "urn:TestArtifact:402"
                                }
                                """;

        // Act
        var json = element.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void TypeNew_Artifact_FailsValidation_Empty_SpdxId()
    {
        // Arrange
        var element = TestFactory.New<TestArtifact>(TestCreationInfo);
        element.SpdxId = string.Empty;

        // Act
        var exception = Record.Exception(() => element.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object TestArtifact, property SpdxId: Field is empty", exception.Message);
    }


    [Fact]
    public void TypeNew_Artifact_FailsValidation_Empty_Type()
    {
        // Arrange
        var element = TestFactory.New<TestArtifact>(TestCreationInfo);
        element.Type = string.Empty;

        // Act
        var exception = Record.Exception(() => element.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object TestArtifact, property Type: Field is empty", exception.Message);
    }
}