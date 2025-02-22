using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Software.Elements;
using Spdx3.Model.Software.Enums;

namespace Spdx3.Tests.Model.Core.Elements;

public class RelationshipTest : BaseElementTestClass
{
    [Fact]
    public void Relationship_HasCorrectType()
    {
        // Arrange
        var baby = new Person(TestIdFactory, TestCreationInfo) { Name = "Baby" };
        var daddy = new Person(TestIdFactory, TestCreationInfo) { Name = "Daddy" };
        var mommy = new Person(TestIdFactory, TestCreationInfo) { Name = "Mommy" };
        var parents = new List<Element> { daddy, mommy };

        // Act
        var relationship = new Relationship(TestIdFactory, TestCreationInfo, RelationshipType.dependsOn, baby, parents);

        // Assert
        Assert.NotNull(relationship);
        Assert.Equal("Relationship", relationship.Type);
    }

    [Fact]
    public void Relationship_ConstructorGeneratesId()
    {
        // Arrange
        var baby = new Person(TestIdFactory, TestCreationInfo) { Name = "Baby" };
        var daddy = new Person(TestIdFactory, TestCreationInfo) { Name = "Daddy" };
        var mommy = new Person(TestIdFactory, TestCreationInfo) { Name = "Mommy" };
        var parents = new List<Element> { daddy, mommy };

        // Act
        var relationship = new Relationship(TestIdFactory, TestCreationInfo, RelationshipType.dependsOn, baby, parents);

        // Assert
        Assert.NotNull(relationship);
        Assert.Equal("urn:Relationship:testRef", relationship.SpdxId);
    }

    [Fact]
    public void Relationship_IsSerializableToJson_Simple_Family()
    {
        // Arrange
        var baby = new Person(TestIdFactory, TestCreationInfo) { Name = "Baby" };
        var daddy = new Person(TestIdFactory, TestCreationInfo) { Name = "Daddy" };
        var mommy = new Person(TestIdFactory, TestCreationInfo) { Name = "Mommy" };
        var parents = new List<Element> { daddy, mommy };

        var relationship = new Relationship(TestIdFactory, TestCreationInfo, RelationshipType.dependsOn, baby, parents);

        // Act
        var json = relationship.ToJson();

        // Assert
        const string expected = """
                                {
                                  "relationshipType": "dependsOn",
                                  "from": "urn:Person:testRef",
                                  "to": [
                                    "urn:Person:testRef",
                                    "urn:Person:testRef"
                                  ],
                                  "creationInfo": "urn:CreationInfo:testRef",
                                  "type": "Relationship",
                                  "spdxId": "urn:Relationship:testRef"
                                }
                                """;
        Assert.Equal(expected, json);
    }


    [Fact]
    public void Relationship_IsSerializableToJson_MoreComplicated_Software()
    {
        // Arrange
        var solution = new SoftwarePackage(TestIdFactory, TestCreationInfo)
        {
            Name = "DPAPI",
            Description = "Solution",
            PrimaryPurpose = SoftwarePurpose.application
        };

        var project1 = new SoftwarePackage(TestIdFactory, TestCreationInfo)
        {
            Name = "DPAPI.Web",
            Description = "Project",
            PrimaryPurpose = SoftwarePurpose.application
        };

        var project2 = new SoftwarePackage(TestIdFactory, TestCreationInfo)
        {
            Name = "GlobalTypes",
            Description = "Project",
            PrimaryPurpose = SoftwarePurpose.library
        };

        var project3 = new SoftwarePackage(TestIdFactory, TestCreationInfo)
        {
            Name = "GlobalTypes",
            Description = "Project",
            PrimaryPurpose = SoftwarePurpose.library
        };

        var toProjects = new List<Element>
        {
            project1,
            project2,
            project3
        };


        var relationship = new Relationship(TestIdFactory, TestCreationInfo, RelationshipType.dependsOn, solution,
            toProjects)
        {
            Comment = "Test Comment",
            Summary = "Test Summary",
            Description = "Test Description"
        };

        // Act
        var json = relationship.ToJson();

        // Assert
        const string expected = """
                                {
                                  "relationshipType": "dependsOn",
                                  "from": "urn:software_Package:testRef",
                                  "to": [
                                    "urn:software_Package:testRef",
                                    "urn:software_Package:testRef",
                                    "urn:software_Package:testRef"
                                  ],
                                  "comment": "Test Comment",
                                  "creationInfo": "urn:CreationInfo:testRef",
                                  "description": "Test Description",
                                  "summary": "Test Summary",
                                  "type": "Relationship",
                                  "spdxId": "urn:Relationship:testRef"
                                }
                                """;
        Assert.Equal(expected, json);
    }
}