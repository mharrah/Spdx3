using Spdx3.Utility;

namespace Spdx3.Tests.Utility;

internal class TestSpdxIdFactory : ISpdxIdFactory
{
    public string New(string type)
    {
        return $"urn:{type}:testRef";
    }
}