using System.Collections.ObjectModel;
using Spdx3.Utility;

namespace Spdx3.Model.Lite;

public class LiteDomainComplianceChecker
{
    public ReadOnlyCollection<LiteDomainComplianceFinding> Findings { get;}
    
    public bool IsCompliant => Findings.All(x => x.FindingType != LiteDomainComplianceFindingType.problem);

    public LiteDomainComplianceChecker(Catalog catalog)
    {
        var v = new LiteDomainComplianceVisitor();
        foreach (var baseModelClass in catalog.Items.Values)
        {
            if (baseModelClass is ILiteDomainCompliantElement liteClass)
            {
                liteClass.Accept(v);
            }
        }

        Findings = new ReadOnlyCollection<LiteDomainComplianceFinding>(v.Findings);
    }
}