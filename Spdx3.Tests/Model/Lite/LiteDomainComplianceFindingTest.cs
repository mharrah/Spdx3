using Spdx3.Model.Core.Classes;
using Spdx3.Model.Lite;

namespace Spdx3.Tests.Model.Lite;

public class LiteDomainComplianceFindingTest : BaseModelTest
{
    [Fact]
    public void Finding_ToString_ShouldReturnExpectedResult_Ctor1()
    {
        // Arrange
        var finding = new LiteDomainComplianceFinding(LiteDomainComplianceFindingType.problem, 
            new Agent(TestCatalog, TestCreationInfo), "somePropertyName", "this is what's wrong");
        
        // Act
        var fString = finding.ToString();
        
        // Assert
        Assert.Equal("Problem: Agent[urn:Agent:40f].somePropertyName: this is what's wrong", fString);
    }
    
    [Fact]
    public void Finding_ToString_ShouldReturnExpectedResult_Ctor2()
    {
        // Arrange
        var finding = new LiteDomainComplianceFinding(LiteDomainComplianceFindingType.problem, 
            new Agent(TestCatalog, TestCreationInfo), "this is what's wrong");
        
        // Act
        var fString = finding.ToString();
        
        // Assert
        Assert.Equal("Problem: Agent[urn:Agent:40f]: this is what's wrong", fString);
    }

}