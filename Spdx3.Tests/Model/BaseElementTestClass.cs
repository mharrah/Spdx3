using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.NonElements;
using Spdx3.Tests.Utility;
using Spdx3.Utility;

namespace Spdx3.Tests.Model;

public abstract class BaseElementTestClass
{
    protected readonly IList<Agent> NoAgents = new List<Agent>();

    protected readonly ISpdxIdFactory TestIdFactory = new TestSpdxIdFactory();

    protected readonly CreationInfo TestCreationInfo;

    protected BaseElementTestClass()
    {
        TestCreationInfo = new CreationInfo(TestIdFactory, NoAgents);
    }
}