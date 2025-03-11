namespace Spdx3.Tests.Model.Core.Classes;

public class ArtifactTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_Artifact_HasRequiredFields()
    {
        // Arrange
        var element = new TestArtifact(TestSpdxCatalog, TestCreationInfo);

        // Assert
        Assert.Null(Record.Exception(() => element.Validate()));
        Assert.Equal("TestArtifact", element.Type);
    }

    [Fact]
    public void BrandNew_Artifact_SerializesProperly()
    {
        // Arrange
        var element = new TestArtifact(TestSpdxCatalog, TestCreationInfo);
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
        var element = new TestArtifact(TestSpdxCatalog, TestCreationInfo)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName"
        };

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
    public void TypeNew_Artifact_FailsValidation_Empty_Type()
    {
        // Arrange
        var element = new TestArtifact(TestSpdxCatalog, TestCreationInfo)
        {
            Type = string.Empty
        };

        // Act
        var exception = Record.Exception(() => element.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object TestArtifact, property Type: Field is empty", exception.Message);
    }
}