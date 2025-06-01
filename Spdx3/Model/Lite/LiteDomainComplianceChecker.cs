using System.Collections.ObjectModel;
using Spdx3.Utility;

namespace Spdx3.Model.Lite;

public class LiteDomainComplianceChecker
{
    private readonly List<LiteDomainComplianceFinding> _findings;
    public ReadOnlyCollection<LiteDomainComplianceFinding> Findings => _findings.AsReadOnly();

    public bool IsCompliant => Problems.Count == 0;

    public ReadOnlyCollection<LiteDomainComplianceFinding> Problems =>
        _findings.Where(f => f.FindingType == LiteDomainComplianceFindingType.problem).ToList().AsReadOnly();

    public ReadOnlyCollection<LiteDomainComplianceFinding> Recommendations =>
        _findings.Where(f => f.FindingType == LiteDomainComplianceFindingType.recommendation).ToList().AsReadOnly();

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

        _findings = v.Findings;
    }
}