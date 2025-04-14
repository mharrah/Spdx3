using System.Collections.ObjectModel;
using Spdx3.Utility;

namespace Spdx3.Model.Lite;

public class LiteDomain
{
    public static ReadOnlyCollection<LiteDomainComplianceProblem> GetComplianceProblems(Catalog catalog)
    {
        var v = new LiteDomainComplianceVisitor();
        foreach (var baseModelClass in catalog.Items.Values)
        {
            if (baseModelClass is ILiteDomainCompliantElement liteClass)
            {
                liteClass.Accept(v);
            }
        }
        return new ReadOnlyCollection<LiteDomainComplianceProblem>(v.Problems);
    }
}