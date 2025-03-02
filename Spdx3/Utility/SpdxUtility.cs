using Spdx3.Exceptions;

namespace Spdx3.Utility;

public class SpdxUtility
{
    private static readonly Dictionary<string, string> PrefixesForNamespaces = new()
    {
        { "Model.Core", "" },
        { "Model.Security", "security_" },
        { "Model.Software", "software_" },
        { "Model.Licensing", "licensing_" },
        { "Model.SimpleLicensing", "simplelicensing_" },
        { "Model.ExpandedLicensing", "expandedlicensing_" },
        { "Model.Dataset", "dataset_" },
        { "Model.AI", "ai_" },
        { "Model.Build", "build_" },
        { "Model.Lite", "lite_" },
        { "Model.Extension", "extension_" }
    };

    public static string SpdxTypeForClass(Type classType)
    {
        if (classType.Namespace == null)
        {
            throw new Spdx3Exception($"Unable to determine SPDX3 node type value for {classType.FullName}");
        }

        foreach (var prefix in PrefixesForNamespaces.Keys.Where(
                     prefix => classType.Namespace.StartsWith($"Spdx3.{prefix}")
                               || classType.Namespace.StartsWith($"Spdx3.Tests.{prefix}")
                 )
                )
        {
            return $"{PrefixesForNamespaces[prefix]}{classType.Name}";
        }

        throw new Spdx3Exception($"Unable to determine SPDX3 node type value for {classType.FullName}");
    }
}