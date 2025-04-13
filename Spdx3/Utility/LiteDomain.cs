using System.Collections.ObjectModel;
using Spdx3.Model.Core.Classes;

namespace Spdx3.Utility;

public class LiteDomain
{
    public static ReadOnlyCollection<LiteDomainComplianceProblem> GetComplianceProblems(SpdxDocument document)
    {
        var v = new LiteDomainComplianceVisitor();
        v.Visit(document);
        return new ReadOnlyCollection<LiteDomainComplianceProblem>(v.Problems);
    }
}