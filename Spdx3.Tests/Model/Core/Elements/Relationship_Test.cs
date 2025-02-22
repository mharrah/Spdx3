using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        var baby = new Person(TestIdFactory, TestCreationInfo);
        baby.Name = "Baby";
        var daddy = new Person(TestIdFactory, TestCreationInfo);
        daddy.Name = "Daddy";
        var mommy = new Person(TestIdFactory, TestCreationInfo);
        mommy.Name = "Mommy";

        List<Element> parents = new List<Element>();
        parents.Add(daddy);
        parents.Add(mommy);

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
        var baby = new Person(TestIdFactory, TestCreationInfo);
        baby.Name = "Baby";
        var daddy = new Person(TestIdFactory, TestCreationInfo);
        daddy.Name = "Daddy";
        var mommy = new Person(TestIdFactory, TestCreationInfo);
        mommy.Name = "Mommy";

        List<Element> parents = new List<Element>();
        parents.Add(daddy);
        parents.Add(mommy);

        // Act
        var relationship = new Relationship(TestIdFactory, TestCreationInfo, RelationshipType.dependsOn, baby, parents);

        // Assert
        Assert.NotNull(relationship);
        Assert.Equal("urn:Relationship:testRef", relationship.SpdxId.ToString());
    }

    [Fact]
    public void Relationship_IsSerializableToJson_Simple_Family()
    {
        // Arrange
        var baby = new Person(TestIdFactory, TestCreationInfo);
        baby.Name = "Baby";
        var daddy = new Person(TestIdFactory, TestCreationInfo);
        daddy.Name = "Daddy";
        var mommy = new Person(TestIdFactory, TestCreationInfo);
        mommy.Name = "Mommy";

        List<Element> parents = new List<Element>();
        parents.Add(daddy);
        parents.Add(mommy);

        var relationship = new Relationship(TestIdFactory, TestCreationInfo, RelationshipType.dependsOn, baby, parents);

        // Act
        var json = relationship.ToJson();

        // Assert
        var expected = """
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
        var solution = new SoftwarePackage(TestIdFactory, TestCreationInfo);
        solution.Name = "DPAPI";
        solution.Description = "Solution";
        solution.PrimaryPurpose = SoftwarePurpose.application;

        List<Element> toProjects = new List<Element>();
        var project1 = new SoftwarePackage(TestIdFactory, TestCreationInfo);
        project1.Name = "DPAPI.Web";
        project1.Description = "Project";
        project1.PrimaryPurpose = SoftwarePurpose.application;

        var project2 = new SoftwarePackage(TestIdFactory, TestCreationInfo);
        project1.Name = "GlobalTypes";
        project1.Description = "Project";
        project1.PrimaryPurpose = SoftwarePurpose.library;

        var project3 = new SoftwarePackage(TestIdFactory, TestCreationInfo);
        project1.Name = "GlobalTypes";
        project1.Description = "Project";
        project1.PrimaryPurpose = SoftwarePurpose.library;

        toProjects.Add(project1);
        toProjects.Add(project2);
        toProjects.Add(project3);


        var relationship = new Relationship(TestIdFactory, TestCreationInfo, RelationshipType.dependsOn, solution, toProjects);
        relationship.Comment = "Test Comment";
        relationship.Summary = "Test Summary";
        relationship.Description = "Test Description";

        // Act
        var json = relationship.ToJson();

        // Assert
        var expected = """
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