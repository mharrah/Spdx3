using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.NonElements;
using Spdx3.Tests.Utility;
using Spdx3.Utility;

namespace Spdx3.Tests.Model;

public abstract class BaseElementTestClass
{
    private readonly IList<Agent> _noAgents = new List<Agent>();

    protected readonly CreationInfo TestCreationInfo;

    protected readonly ISpdxIdFactory TestIdFactory = new TestSpdxIdFactory();

    protected BaseElementTestClass()
    {
        TestCreationInfo = new CreationInfo(TestIdFactory, _noAgents);
    }
}