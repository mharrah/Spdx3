using System.Collections;
using System.Text.RegularExpressions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Model.Software.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.Lite;

internal class LiteDomainComplianceVisitor : ILiteDomainComplianceVisitor
{
    internal IList<LiteDomainComplianceFinding> Findings { get; } = new List<LiteDomainComplianceFinding>();

    public void Visit(SpdxDocument spdxDocument)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, spdxDocument, nameof(spdxDocument.CreationInfo), spdxDocument.CreationInfo);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, spdxDocument, nameof(spdxDocument.SpdxId), spdxDocument.SpdxId);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, spdxDocument, nameof(spdxDocument.Element), (IList)spdxDocument.Element);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, spdxDocument, nameof(spdxDocument.RootElement), (IList)spdxDocument.RootElement);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, spdxDocument, nameof(spdxDocument.Comment), spdxDocument.Comment);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, spdxDocument, nameof(spdxDocument.DataLicense), spdxDocument.DataLicense);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, spdxDocument, nameof(spdxDocument.Name), spdxDocument.Name);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, spdxDocument, nameof(spdxDocument.NamespaceMap), (IList)spdxDocument.NamespaceMap);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, spdxDocument, nameof(spdxDocument.VerifiedUsing), (IList)spdxDocument.VerifiedUsing);
        CheckAtLeastOneMemberOfType(LiteDomainComplianceFindingType.problem, spdxDocument, nameof(spdxDocument.Element), (IList)spdxDocument.Element, typeof(Sbom)); 
        CheckContainsOnlyType(LiteDomainComplianceFindingType.recommendation, spdxDocument, nameof(spdxDocument.Element), (IList)spdxDocument.Element, typeof(Sbom)); 
    }

    public void Visit(CreationInfo creationInfo)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, creationInfo, nameof(creationInfo.Created), creationInfo.Created);
        CheckMatchesPattern(LiteDomainComplianceFindingType.problem, creationInfo, nameof(creationInfo.SpecVersion), creationInfo.SpecVersion, @"^3\.0\.\d+$");
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, creationInfo, nameof(creationInfo.CreatedBy), (IList)creationInfo.CreatedBy);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, creationInfo, nameof(creationInfo.Comment), creationInfo.Comment);
    }

    public void Visit(Agent agent)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, agent, nameof(agent.CreationInfo), agent.CreationInfo);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, agent, nameof(agent.SpdxId), agent.SpdxId);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, agent, nameof(agent.Name), agent.Name);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, agent, nameof(agent.ExternalIdentifier), (IList)agent.ExternalIdentifier);
    }

    public void Visit(ExternalIdentifier externalIdentifier)
    {
        throw new NotImplementedException();
    }

    public void Visit(Hash hash)
    {
        throw new NotImplementedException();
    }

    public void Visit(NamespaceMap namespaceMap)
    {
        throw new NotImplementedException();
    }

    public void Visit(Relationship relationship)
    {
        throw new NotImplementedException();
    }

    public void Visit(LicenseExpression licenseExpression)
    {
        throw new NotImplementedException();
    }

    public void Visit(SimpleLicensingText simpleLicensingText)
    {
        throw new NotImplementedException();
    }

    public void Visit(Package package)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, package, nameof(package.CopyrightText), package.CopyrightText);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, package, nameof(package.CreationInfo), package.CreationInfo);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, package, nameof(package.Name), package.Name);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, package, nameof(package.PackageVersion), package.PackageVersion);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, package, nameof(package.SpdxId), package.SpdxId);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, package, nameof(package.SuppliedBy), package.SuppliedBy);

        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.AttributionText), (IList)package.AttributionText);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.BuiltTime), package.BuiltTime);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.Comment), package.Comment);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.DownloadLocation), package.DownloadLocation);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.HomePage), package.HomePage);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.ReleaseTime), package.ReleaseTime);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.SupportLevel), (IList)package.SupportLevel);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.ValidUntilTime), package.ValidUntilTime);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.VerifiedUsing), (IList)package.VerifiedUsing);
        CheckContainsOnlyType(LiteDomainComplianceFindingType.recommendation, package, nameof(package.VerifiedUsing), (IList)package.VerifiedUsing, typeof(Hash));

        if (string.IsNullOrWhiteSpace(package.DownloadLocation) && (package.PackageUrl is null || string.IsNullOrWhiteSpace(package.PackageUrl.ToString())))
        {
            Findings.Add(new LiteDomainComplianceFinding(LiteDomainComplianceFindingType.problem, package, "N/A", 
                $"Either {nameof(package.DownloadLocation)} or {nameof(package.PackageUrl)} is required"));
        }
    }

    public void Visit(Sbom sbom)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, sbom, nameof(sbom.CreationInfo), sbom.CreationInfo);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, sbom, nameof(sbom.SpdxId), sbom.SpdxId);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, sbom, nameof(sbom.Element), (IList)sbom.Element);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, sbom, nameof(sbom.RootElement), (IList)sbom.RootElement);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, sbom, nameof(sbom.Comment), sbom.Comment);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, sbom, nameof(sbom.Name), sbom.Name);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, sbom, nameof(sbom.VerifiedUsing), (IList)sbom.VerifiedUsing);
        CheckAtLeastOneMemberOfType(LiteDomainComplianceFindingType.problem, sbom, nameof(sbom.Element), (IList)sbom.Element, typeof(Package)); 
        CheckContainsOnlyType(LiteDomainComplianceFindingType.recommendation, sbom, nameof(sbom.Element), (IList)sbom.Element, typeof(Package)); 
    }

    private void CheckNotNullOrEmpty(LiteDomainComplianceFindingType findingType, BaseModelClass obj, string propertyName, IList? listVal)
    {
        var verb = (findingType == LiteDomainComplianceFindingType.problem) ? "requires" : "should have";
        if (listVal is null || listVal.Count < 1)
        {
            Findings.Add(new LiteDomainComplianceFinding(findingType, obj, propertyName, $"List {verb} at least one item"));
        }
    }

    
    private void CheckAtLeastOneMemberOfType(LiteDomainComplianceFindingType findingType, BaseModelClass obj, string propertyName, IList? listVal, Type requiredType)
    {
        var verb = (findingType == LiteDomainComplianceFindingType.problem) ? "requires" : "should have";
        if (listVal is null || listVal.Count < 1)
        {
            Findings.Add(new LiteDomainComplianceFinding(findingType, obj, propertyName, $"List {verb} at least one item of type {requiredType.Name}"));
            return;
        }

        foreach (var member in listVal)
        {
            if (member.GetType() == requiredType)
            {
                return;
            }
        }
        Findings.Add(new LiteDomainComplianceFinding(findingType, obj, propertyName, $"List {verb} at least one item of type {requiredType.Name}"));
    }

    private void CheckContainsOnlyType(LiteDomainComplianceFindingType findingType, BaseModelClass obj, string propertyName, IList? listVal, Type desiredType)
    {
        var verb = (findingType == LiteDomainComplianceFindingType.problem) ? "must" : "should";
        if (listVal is null) {
            return;
        }

        foreach (var member in listVal)
        {
            if (member.GetType() != desiredType)
            {
                Findings.Add(new LiteDomainComplianceFinding(findingType, obj, propertyName, $"List {verb} contain only items of type {desiredType.Name}"));
                return;
            }
        }
    }

    private void CheckMatchesPattern(LiteDomainComplianceFindingType findingType, BaseModelClass obj, string propertyName, string? strVal, string regexPattern)
    {
        if (strVal is not null && !Regex.Match(strVal, regexPattern).Success)
        {
            Findings.Add(new LiteDomainComplianceFinding(findingType, obj, propertyName, $"Value '{strVal}' is invalid"));
        }
    }

    private void CheckNotNullOrEmpty(LiteDomainComplianceFindingType findingType, BaseModelClass obj, string propertyName, object? objVal)
    {
        var verb = (findingType == LiteDomainComplianceFindingType.problem) ? "required" : "recommended";
        if (objVal is null)
        {
            Findings.Add(new LiteDomainComplianceFinding(findingType, obj, propertyName, $"Value {verb}"));
        }
    }

    private void CheckNotNullOrEmpty(LiteDomainComplianceFindingType findingType, BaseModelClass obj, string fieldName, Uri? uriVal)
    {
        if (uriVal is null)
        {
            var verb = (findingType == LiteDomainComplianceFindingType.problem) ? "required" : "recommended";
            Findings.Add(new LiteDomainComplianceFinding(findingType, obj, fieldName, $"Value {verb}"));
            return;
        }

        if (!uriVal.IsWellFormedOriginalString())
        {
            Findings.Add(new LiteDomainComplianceFinding(findingType, obj, fieldName,
                $"Value of '{uriVal.ToString()}' is not a well-formed URI"));
        }
    }
}