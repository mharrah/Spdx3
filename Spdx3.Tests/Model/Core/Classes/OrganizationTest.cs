using Spdx3.Model.Core.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class OrganizationTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_Organization_SerializesProperly()
    {
        // Arrange
        var org = new Organization(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Organization",
                                  "spdxId": "urn:Organization:40f"
                                }
                                """;

        // Act
        var json = ToJson(org);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Organization_SerializesProperly()
    {
        // Arrange
        var org = new Organization(TestCatalog, TestCreationInfo)
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
                                  "spdxId": "urn:Organization:40f"
                                }
                                """;

        // Act
        var json = ToJson(org);

        // Assert
        Assert.Equal(expected, json);
    }
}