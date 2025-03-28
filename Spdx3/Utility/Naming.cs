using Spdx3.Exceptions;

namespace Spdx3.Utility;

public static class Naming
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

    public static string ClassNameForSpdxType(Dictionary<string, object> hashTable)
    {
        var spdxType = (string)hashTable[hashTable.ContainsKey("type") ? "type" : "@type"];
        if (!spdxType.Contains('_'))
        {
            return $"Spdx3.Model.Core.Classes.{spdxType}";
        }

        foreach (var prefix in PrefixesForNamespaces.Where(prefix =>
                     !string.IsNullOrWhiteSpace(prefix.Value) && spdxType.StartsWith(prefix.Value)))
        {
            return $"Spdx3.{prefix.Key}.Classes.{spdxType[prefix.Value.Length..]}";
        }

        throw new Spdx3SerializationException($"Unable to determine class type for node of Type={spdxType}");
    }
}