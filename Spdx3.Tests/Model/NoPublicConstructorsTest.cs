using System.Reflection;
using Spdx3.Model;

namespace Spdx3.Tests.Model;

/// <summary>
/// All of the classes in the Model should have no public constructor.  They should all be internal to the SPDX3 project.
/// </summary>
public class NoPublicConstructorsTest
{
    [Fact]
    public void No_Classes_With_Public_Constructor()
    {
        List<Type> violations = new List<Type>();
        var assembly = Assembly.GetAssembly(typeof(BaseSpdxClass));
        Assert.NotNull(assembly);
        
        foreach (var t in assembly.GetTypes())
        {
            if (t.Namespace == null) continue;
            if (!t.Namespace.StartsWith("Spdx3.Model")) continue;
            if (!t.IsClass) continue;
            if (!t.IsPublic) continue;
            if (!t.IsAssignableTo(typeof(BaseSpdxClass))) continue;
            foreach (var c in t.GetConstructors())
            {
                if (c.IsPublic) violations.Add(t);
            }
            
        }

        if (violations.Count != 0)
        {
            Assert.Fail($"The following classes have public constructors: {String.Join("; ", violations)}");
        }
    }

}

