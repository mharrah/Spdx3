using System.Collections;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Model.Software.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.Lite;

internal class LiteDomainComplianceVisitor : ILiteDomainComplianceVisitor
{
    public IList<LiteDomainComplianceProblem> Problems { get; } = new List<LiteDomainComplianceProblem>();

    public void Visit(SpdxDocument spdxDocument)
    {
        TestMandatory(spdxDocument, spdxDocument.CreationInfo.GetType().Name, spdxDocument.CreationInfo);
        TestMandatory(spdxDocument, spdxDocument.SpdxId.GetType().Name, spdxDocument.SpdxId);
        TestHasOneMember(spdxDocument, nameof(spdxDocument.Element), (IList)spdxDocument.Element);
    }

    public void Visit(CreationInfo creationInfo)
    {
        throw new NotImplementedException();
    }

    public void Visit(Agent agent)
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    public void Visit(Sbom sbom)
    {
        throw new NotImplementedException();
    }
    
    private void TestHasOneMember(BaseModelClass obj, string propertyName, IList? listVal)
    {
        if (listVal is null || listVal.Count < 1)
        {
            Problems.Add(new LiteDomainComplianceProblem(obj, propertyName, "List requires at least one item"));
        }
    }

    private void TestMandatory(BaseModelClass obj, string propertyName, string? strVal)
    {
        if (string.IsNullOrWhiteSpace(strVal))
        {
            Problems.Add(new LiteDomainComplianceProblem(obj, propertyName, "Value required"));
        }
    }

    private void TestMandatory(BaseModelClass obj, string propertyName, object? objVal)
    {
        if (objVal is null)
        {
            Problems.Add(new LiteDomainComplianceProblem(obj, propertyName, "Value required"));
        }
    }

    private void TestMandatory(BaseModelClass obj, string fieldName, Uri? uriVal)
    {
        if (uriVal is null)
        {
            Problems.Add(new LiteDomainComplianceProblem(obj, fieldName, "Value required"));
            return;
        }

        if (!uriVal.IsWellFormedOriginalString())
        {
            Problems.Add(new LiteDomainComplianceProblem(obj, fieldName,
                $"Value of '{uriVal.ToString()}' is not a well-formed URI"));
        }
    }
}