namespace Spdx3.Tests.Model.Core.Classes;

public class ArtifactTest : BaseModelTest
{
    [Fact]
    public void BrandNew_Artifact_HasRequiredFields()
    {
        // Arrange
        var element = new ArtifactConcreteTestFixture(TestCatalog, TestCreationInfo);

        // Assert
        Assert.Null(Record.Exception(() => element.Validate()));
        Assert.Equal("ArtifactConcreteTestFixture", element.Type);
    }

    [Fact]
    public void BrandNew_Artifact_SerializesProperly()
    {
        // Arrange
        var element = new ArtifactConcreteTestFixture(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "ArtifactConcreteTestFixture",
                                  "spdxId": "urn:ArtifactConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(element);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Artifact_SerializesProperly()
    {
        // Arrange
        var element = new ArtifactConcreteTestFixture(TestCatalog, TestCreationInfo)
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
                                  "type": "ArtifactConcreteTestFixture",
                                  "spdxId": "urn:ArtifactConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(element);

        // Assert
        Assert.Equal(expected, json);
    }


    [Fact]
    public void TypeNew_Artifact_FailsValidation_Empty_Type()
    {
        // Arrange
        var element = new ArtifactConcreteTestFixture(TestCatalog, TestCreationInfo)
        {
            Type = string.Empty
        };

        // Act
        var exception = Record.Exception(() => element.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object ArtifactConcreteTestFixture, property Type: String field is empty", exception.Message);
    }
}