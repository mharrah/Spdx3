namespace Spdx3.Tests.Model.Core.Classes;

public class IntegrityMethodTest : BaseModelTest
{
    [Fact]
    public void IntegrityMethod_Basics()
    {
        // Act
        var integrityMethod = new IntegrityMethodConcreteTestFixture(TestCatalog);

        // Assert
        Assert.NotNull(integrityMethod);
        Assert.IsType<IntegrityMethodConcreteTestFixture>(integrityMethod);
        Assert.Equal("IntegrityMethodConcreteTestFixture", integrityMethod.Type);
        Assert.Equal(new Uri("urn:IntegrityMethodConcreteTestFixture:40f"), integrityMethod.SpdxId);
    }

    [Fact]
    public void IntegrityMethod_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var integrityMethod = new IntegrityMethodConcreteTestFixture(TestCatalog);

        const string expected = """
                                {
                                  "type": "IntegrityMethodConcreteTestFixture",
                                  "spdxId": "urn:IntegrityMethodConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(integrityMethod);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void IntegrityMethod_FullyPopulated_SerializesAsExpected()
    {
        // Arrange
        var integrityMethod = new IntegrityMethodConcreteTestFixture(TestCatalog)
        {
            Comment = "Test comment"
        };

        const string expected = """
                                {
                                  "comment": "Test comment",
                                  "type": "IntegrityMethodConcreteTestFixture",
                                  "spdxId": "urn:IntegrityMethodConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(integrityMethod);

        // Assert
        Assert.Equal(expected, json);
    }
}