using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.ExpandedLicensing.Classes;

/// <summary>
/// Portion of an AnyLicenseInfo representing a set of licensing information where all elements apply.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/ExpandedLicensing/Classes/ConjunctiveLicenseSet/
/// </summary>
public class ConjunctiveLicenseSet : AnyLicenseInfo
{
    [JsonPropertyName("expandedlicensing_member")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<AnyLicenseInfo> Member { get; set; } = new List<AnyLicenseInfo>();

    /// <summary>
    /// No-arg constructor required for serialization/deserialization
    /// </summary>
    protected internal ConjunctiveLicenseSet()
    {
    }

    [SetsRequiredMembers]
    public ConjunctiveLicenseSet(Catalog catalog, CreationInfo creationInfo, IList<AnyLicenseInfo> licenses) : base(catalog, creationInfo)
    {
        if (licenses.Count < 2)
        {
            throw new Spdx3Exception("ConjunctiveLicenseSets must have at least 2 licenses.");
        }

        foreach (var anyLicenseInfo in licenses)
        {
            Member.Add(anyLicenseInfo);
        }
    }

    public override void Validate()
    {
        base.Validate();
        if (Member.Count < 2)
        {
            throw new Spdx3ValidationException("ConjunctiveLicenseSets must have at least 2 licenses.");
        }
    }
}