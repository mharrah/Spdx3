using System.Collections;
using Spdx3.Model;
using Spdx3.Model.Core.Classes;

namespace Spdx3.Utility;

internal class LiteDomainComplianceVisitor : IModelVisitor
{
    public IList<LiteDomainComplianceProblem> Problems { get; } = new List<LiteDomainComplianceProblem>();
    
    public void Visit(SpdxDocument spdxDocument)
    {
        TestMandatory(spdxDocument, spdxDocument.CreationInfo.GetType().Name, spdxDocument.CreationInfo);
        TestMandatory(spdxDocument, spdxDocument.SpdxId.GetType().Name, spdxDocument.SpdxId);
        TestHasOneMember(spdxDocument, nameof(spdxDocument.Element), (IList)spdxDocument.Element);
    }

    private void TestHasOneMember(IModelClass obj, string propertyName, IList? listVal)
    {
        if (listVal is null || listVal.Count < 1)
        {
            Problems.Add(new LiteDomainComplianceProblem(obj, propertyName, "List requires at least one item"));
        }
    }

    private void TestMandatory(IModelClass obj, string propertyName, string? strVal)
    {
        if (string.IsNullOrWhiteSpace(strVal))
        {
            Problems.Add(new LiteDomainComplianceProblem(obj, propertyName, "Value required"));
        }
    }

    private void TestMandatory(IModelClass obj, string propertyName, object? objVal)
    {
        if (objVal is null)
        {
            Problems.Add(new LiteDomainComplianceProblem(obj, propertyName, "Value required"));
        }
    }

    private void TestMandatory(IModelClass obj, string fieldName, Uri? uriVal)
    {
        if (uriVal is null)
        {
            Problems.Add(new LiteDomainComplianceProblem(obj, fieldName, "Value required"));
            return;
        }
        if (!uriVal.IsWellFormedOriginalString())
        {
            Problems.Add(new LiteDomainComplianceProblem(obj, fieldName, $"Value of '{uriVal.ToString()}' is not a well-formed URI"));
        }
    }

    
    public void Visit(IModelClass element)
    {
        
    }
    
}