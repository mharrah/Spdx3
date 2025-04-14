using Spdx3.Model.Core.Classes;
using Spdx3.Model.Lite;
using Spdx3.Tests.Model;
using Spdx3.Utility;

namespace Spdx3.Tests.Utility;

public class LiteDomainTest : BaseModelTest
{
    [Fact]
    public void TestDomainCompliance()
    {
        var spdxDocument = new SpdxDocument(TestCatalog, TestCreationInfo);
        
        var problems = LiteDomain.GetComplianceProblems(TestCatalog);
        
        Assert.NotEmpty(problems);
    }
}