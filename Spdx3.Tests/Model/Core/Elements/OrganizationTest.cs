using Spdx3.Model.Core.Elements;

namespace Spdx3.Tests.Model.Core.Elements;

public class OrganizationTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_Organization_SerializesProperly()
    {
        // Arrange
        var org = new Organization(TestSpdxIdFactory, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Organization",
                                  "spdxId": "urn:Organization:402"
                                }
                                """;

        // Act
        var json = org.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Organization_SerializesProperly()
    {
        // Arrange
        var org = new Organization(TestSpdxIdFactory, TestCreationInfo)
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
                                  "type": "Organization",
                                  "spdxId": "urn:Organization:402"
                                }
                                """;

        // Act
        var json = org.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}