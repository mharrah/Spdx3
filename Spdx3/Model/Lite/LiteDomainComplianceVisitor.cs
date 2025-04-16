using System.Collections;
using System.Text.RegularExpressions;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Model.Software.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.Lite;

/// <summary>
/// Visitor that checks a catalog for compliance with the Spdx Lite domain requirements.
/// See https://spdx.github.io/spdx-spec/v3.0.1/annexes/spdx-lite/
/// </summary>
internal class LiteDomainComplianceVisitor : ILiteDomainComplianceVisitor
{
    internal IList<LiteDomainComplianceFinding> Findings { get; } = new List<LiteDomainComplianceFinding>();

    public void Visit(SpdxDocument spdxDocument)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, spdxDocument, nameof(spdxDocument.CreationInfo),
            spdxDocument.CreationInfo);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, spdxDocument, nameof(spdxDocument.SpdxId),
            spdxDocument.SpdxId);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, spdxDocument, nameof(spdxDocument.Element),
            (IList)spdxDocument.Element);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, spdxDocument, nameof(spdxDocument.RootElement),
            (IList)spdxDocument.RootElement);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, spdxDocument, nameof(spdxDocument.Comment),
            spdxDocument.Comment);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, spdxDocument,
            nameof(spdxDocument.DataLicense), spdxDocument.DataLicense);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, spdxDocument, nameof(spdxDocument.Name),
            spdxDocument.Name);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, spdxDocument,
            nameof(spdxDocument.NamespaceMap), (IList)spdxDocument.NamespaceMap);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, spdxDocument,
            nameof(spdxDocument.VerifiedUsing), (IList)spdxDocument.VerifiedUsing);
        CheckAtLeastOneMemberOfType(LiteDomainComplianceFindingType.problem, spdxDocument, nameof(spdxDocument.Element),
            (IList)spdxDocument.Element, typeof(Sbom));
        CheckContainsOnlyType(LiteDomainComplianceFindingType.recommendation, spdxDocument,
            nameof(spdxDocument.Element), (IList)spdxDocument.Element, typeof(Sbom));
    }

    public void Visit(CreationInfo creationInfo)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, creationInfo, nameof(creationInfo.Created),
            creationInfo.Created);
        CheckMatchesPattern(LiteDomainComplianceFindingType.problem, creationInfo, nameof(creationInfo.SpecVersion),
            creationInfo.SpecVersion, @"^3\.0\.\d+$");
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, creationInfo, nameof(creationInfo.CreatedBy),
            (IList)creationInfo.CreatedBy);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, creationInfo, nameof(creationInfo.Comment),
            creationInfo.Comment);
    }

    public void Visit(Agent agent)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, agent, nameof(agent.CreationInfo),
            agent.CreationInfo);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, agent, nameof(agent.SpdxId), agent.SpdxId);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, agent, nameof(agent.Name), agent.Name);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, agent, nameof(agent.ExternalIdentifier),
            (IList)agent.ExternalIdentifier);
    }

    public void Visit(ExternalIdentifier externalIdentifier)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, externalIdentifier,
            nameof(externalIdentifier.ExternalIdentifierType), externalIdentifier.ExternalIdentifierType);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, externalIdentifier,
            nameof(externalIdentifier.Identifier), externalIdentifier.Identifier);
    }

    public void Visit(Hash hash)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, hash, nameof(hash.Algorithm), hash.Algorithm);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, hash, nameof(hash.HashValue), hash.HashValue);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, hash, nameof(hash.Comment), hash.Comment);
    }

    public void Visit(NamespaceMap namespaceMap)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, namespaceMap, nameof(namespaceMap.Prefix),
            namespaceMap.Prefix);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, namespaceMap, nameof(namespaceMap.Namespace),
            namespaceMap.Namespace);
    }

    public void Visit(Relationship relationship)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, relationship, nameof(relationship.CreationInfo),
            relationship.CreationInfo);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, relationship, nameof(relationship.From),
            relationship.From);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, relationship,
            nameof(relationship.RelationshipType), relationship.RelationshipType);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, relationship, nameof(relationship.SpdxId),
            relationship.SpdxId);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, relationship, nameof(relationship.To),
            relationship.To);
    }

    public void Visit(LicenseExpression licenseExpression)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, licenseExpression,
            nameof(licenseExpression.CreationInfo), licenseExpression.CreationInfo);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, licenseExpression,
            nameof(licenseExpression.LicenseExpressionText),
            licenseExpression.LicenseExpressionText);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, licenseExpression,
            nameof(licenseExpression.SpdxId),
            licenseExpression.SpdxId);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, licenseExpression,
            nameof(licenseExpression.LicenseListVersion),
            licenseExpression.LicenseListVersion);
    }

    public void Visit(SimpleLicensingText simpleLicensingText)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, simpleLicensingText, nameof(simpleLicensingText.CreationInfo),
            simpleLicensingText.CreationInfo);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, simpleLicensingText, nameof(simpleLicensingText.LicenseText),
            simpleLicensingText.LicenseText);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, simpleLicensingText, nameof(simpleLicensingText.SpdxId),
            simpleLicensingText.SpdxId);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, simpleLicensingText, nameof(simpleLicensingText.Comment),
            simpleLicensingText.Comment);

    }

    public void Visit(Package package)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, package, nameof(package.CopyrightText),
            package.CopyrightText);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, package, nameof(package.CreationInfo),
            package.CreationInfo);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, package, nameof(package.Name), package.Name);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, package, nameof(package.PackageVersion),
            package.PackageVersion);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, package, nameof(package.SpdxId), package.SpdxId);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, package, nameof(package.SuppliedBy),
            package.SuppliedBy);

        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.AttributionText),
            (IList)package.AttributionText);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.BuiltTime),
            package.BuiltTime);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.Comment),
            package.Comment);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.DownloadLocation),
            package.DownloadLocation);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.HomePage),
            package.HomePage);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.ReleaseTime),
            package.ReleaseTime);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.SupportLevel),
            (IList)package.SupportLevel);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.ValidUntilTime),
            package.ValidUntilTime);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, package, nameof(package.VerifiedUsing),
            (IList)package.VerifiedUsing);
        CheckContainsOnlyType(LiteDomainComplianceFindingType.recommendation, package, nameof(package.VerifiedUsing),
            (IList)package.VerifiedUsing, typeof(Hash));

        if (string.IsNullOrWhiteSpace(package.DownloadLocation) &&
            (package.PackageUrl is null || string.IsNullOrWhiteSpace(package.PackageUrl.ToString())))
        {
            Findings.Add(new LiteDomainComplianceFinding(LiteDomainComplianceFindingType.problem, package,
                $"Either {nameof(package.DownloadLocation)} or {nameof(package.PackageUrl)} is required"));
        }

        if (package.Catalog is null)
        {
            throw new Spdx3Exception($"Cannot find catalog from Package '{package.SpdxId}'");
        }

        var relationshipsFromThisPackage =
            package.Catalog.GetItems<Relationship>().Where(r => r.From.SpdxId == package.SpdxId);
        var relationshipsToThisPackage = package.Catalog.GetItems<Relationship>()
            .Where(r => r.To.Select(t => t.SpdxId).Contains(package.SpdxId));

        var relationships = relationshipsFromThisPackage;
        var relType = RelationshipType.hasConcludedLicense;
        var relationshipsOfType = package.Catalog.GetRelationshipsOfType(relType);

        if (relationshipsOfType.Count() != 1)
        {
            Findings.Add(new LiteDomainComplianceFinding(LiteDomainComplianceFindingType.problem, package,
                $"Must have exactly one relationship from this package of type '{relType}'"));
        }
        else
        {
            if (relationshipsOfType.First().To.Count() != 1)
            {
                Findings.Add(new LiteDomainComplianceFinding(LiteDomainComplianceFindingType.problem, package,
                    $"{nameof(Relationship)} from {nameof(Package)} of type '{relType}' " +
                    $"must point to exactly one {nameof(AnyLicenseInfo)} object"));
            }
            else
            {
                if (!relationshipsOfType.First().To.First().GetType().IsAssignableTo(typeof(AnyLicenseInfo)))
                {
                    Findings.Add(new LiteDomainComplianceFinding(LiteDomainComplianceFindingType.problem, package,
                        $"{nameof(Relationship)} from {nameof(Package)} of type '{RelationshipType.hasConcludedLicense}' " +
                        $"is not pointing to an {nameof(AnyLicenseInfo)} object"));
                }
            }
        }
    }

    public void Visit(Sbom sbom)
    {
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, sbom, nameof(sbom.CreationInfo),
            sbom.CreationInfo);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, sbom, nameof(sbom.SpdxId), sbom.SpdxId);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, sbom, nameof(sbom.Element), (IList)sbom.Element);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.problem, sbom, nameof(sbom.RootElement),
            (IList)sbom.RootElement);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, sbom, nameof(sbom.Comment), sbom.Comment);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, sbom, nameof(sbom.Name), sbom.Name);
        CheckNotNullOrEmpty(LiteDomainComplianceFindingType.recommendation, sbom, nameof(sbom.VerifiedUsing),
            (IList)sbom.VerifiedUsing);
        CheckAtLeastOneMemberOfType(LiteDomainComplianceFindingType.problem, sbom, nameof(sbom.Element),
            (IList)sbom.Element, typeof(Package));
        CheckContainsOnlyType(LiteDomainComplianceFindingType.recommendation, sbom, nameof(sbom.Element),
            (IList)sbom.Element, typeof(Package));
    }

    private void CheckNotNullOrEmpty(LiteDomainComplianceFindingType findingType, BaseModelClass obj,
        string propertyName, IList? listVal)
    {
        var verb = findingType == LiteDomainComplianceFindingType.problem ? "requires" : "should have";
        if (listVal is null || listVal.Count < 1)
        {
            Findings.Add(new LiteDomainComplianceFinding(findingType, obj, propertyName,
                $"List {verb} at least one item"));
        }
    }


    private void CheckAtLeastOneMemberOfType(LiteDomainComplianceFindingType findingType, BaseModelClass obj,
        string propertyName, IList? listVal, Type requiredType)
    {
        var verb = findingType == LiteDomainComplianceFindingType.problem ? "requires" : "should have";
        if (listVal is null || listVal.Count < 1)
        {
            Findings.Add(new LiteDomainComplianceFinding(findingType, obj, propertyName,
                $"List {verb} at least one item of type {requiredType.Name}"));
            return;
        }

        foreach (var member in listVal)
        {
            if (member.GetType() == requiredType)
            {
                return;
            }
        }

        Findings.Add(new LiteDomainComplianceFinding(findingType, obj, propertyName,
            $"List {verb} at least one item of type {requiredType.Name}"));
    }

    private void CheckContainsOnlyType(LiteDomainComplianceFindingType findingType, BaseModelClass obj,
        string propertyName, IList? listVal, Type desiredType)
    {
        var verb = findingType == LiteDomainComplianceFindingType.problem ? "must" : "should";
        if (listVal is null)
        {
            return;
        }

        foreach (var member in listVal)
        {
            if (member.GetType() != desiredType)
            {
                Findings.Add(new LiteDomainComplianceFinding(findingType, obj, propertyName,
                    $"List {verb} contain only items of type {desiredType.Name}"));
                return;
            }
        }
    }

    private void CheckMatchesPattern(LiteDomainComplianceFindingType findingType, BaseModelClass obj,
        string propertyName, string? strVal, string regexPattern)
    {
        if (strVal is not null && !Regex.Match(strVal, regexPattern).Success)
        {
            Findings.Add(
                new LiteDomainComplianceFinding(findingType, obj, propertyName, $"Value '{strVal}' is invalid"));
        }
    }

    private void CheckNotNullOrEmpty(LiteDomainComplianceFindingType findingType, BaseModelClass obj,
        string propertyName, object? objVal)
    {
        var verb = findingType == LiteDomainComplianceFindingType.problem ? "required" : "recommended";
        if (objVal is null)
        {
            Findings.Add(new LiteDomainComplianceFinding(findingType, obj, propertyName, $"Value {verb}"));
        }
    }

    private void CheckNotNullOrEmpty(LiteDomainComplianceFindingType findingType, BaseModelClass obj, string fieldName,
        Uri? uriVal)
    {
        if (uriVal is null)
        {
            var verb = findingType == LiteDomainComplianceFindingType.problem ? "required" : "recommended";
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