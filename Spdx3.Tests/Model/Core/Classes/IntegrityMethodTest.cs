namespace Spdx3.Tests.Model.Core.Classes;

public class IntegrityMethodTest : BaseModelTestClass
{
    [Fact]
    public void IntegrityMethod_Basics()
    {
        // Act
        var integrityMethod = new TestIntegrityMethod(TestSpdxIdFactory);

        // Assert
        Assert.NotNull(integrityMethod);
        Assert.IsType<TestIntegrityMethod>(integrityMethod);
        Assert.Equal("TestIntegrityMethod", integrityMethod.Type);
        Assert.Equal("urn:TestIntegrityMethod:402", integrityMethod.SpdxId);
    }

    [Fact]
    public void IntegrityMethod_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var integrityMethod = new TestIntegrityMethod(TestSpdxIdFactory);

        const string expected = """
                                {
                                  "type": "TestIntegrityMethod",
                                  "spdxId": "urn:TestIntegrityMethod:402"
                                }
                                """;

        // Act
        var json = integrityMethod.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void IntegrityMethod_FullyPopulated_SerializesAsExpected()
    {
        // Arrange
        var integrityMethod = new TestIntegrityMethod(TestSpdxIdFactory)
        {
            Comment = "Test comment"
        };

        const string expected = """
                                {
                                  "comment": "Test comment",
                                  "type": "TestIntegrityMethod",
                                  "spdxId": "urn:TestIntegrityMethod:402"
                                }
                                """;

        // Act
        var json = integrityMethod.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}