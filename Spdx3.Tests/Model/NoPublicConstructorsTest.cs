using System.Reflection;
using Spdx3.Model;

namespace Spdx3.Tests.Model;

/// <summary>
///     All of the classes in the Model should have public constructor.
/// </summary>
public class NoPublicConstructorsTest
{
    [Fact]
    public void No_Classes_Without_Public_Constructor()
    {
        var violations = new List<Type>();
        var assembly = Assembly.GetAssembly(typeof(BaseSpdxClass));
        Assert.NotNull(assembly);

        foreach (var t in assembly.GetTypes())
        {
            if (t.Namespace == null || !t.Namespace.StartsWith("Spdx3.Model") || !t.IsClass || !t.IsPublic || !t.IsAssignableTo(typeof(BaseSpdxClass)))
            {
                continue;
            }

            violations.AddRange(from c in t.GetConstructors() where !c.IsPublic select t);
        }

        if (violations.Count != 0)
        {
            Assert.Fail($"The following classes have public constructors: {string.Join("; ", violations)}");
        }
    }
}