using System.Reflection;
using Spdx3.Model;

namespace Spdx3.Utility;

public class ConstructorsTest
{
    public static void Main(string[] args)
    {
        Assembly assembly = Assembly.GetAssembly(typeof(BaseSpdxClass));
        var classes = assembly.GetTypes().Where(t => t.IsClass && t.IsPublic && !t.IsAbstract && t.Namespace.StartsWith("Spdx3.Model.")).ToList();
        

        var classesWithoutProtectedInternalDefaultConstructors = new List<string>();
        foreach (var @class in classes)
        {
            try
            {
                Activator.CreateInstance(@class, true);
            }
            catch
            {
                classesWithoutProtectedInternalDefaultConstructors.Add(@class.Name);
            }
        }

        if (classesWithoutProtectedInternalDefaultConstructors.Any())
        {
            throw new ApplicationException($"The following classes do not have protected internal default constructors:\n" +
                                           string.Join("\n", classesWithoutProtectedInternalDefaultConstructors));
        }

    }
}