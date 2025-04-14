namespace Spdx3.Model.Lite;

public class LiteDomainComplianceProblem(BaseModelClass obj, string propertyName, string description)
{
    public readonly BaseModelClass Obj = obj;
    public readonly string PropertyName = propertyName;
    public readonly string Description = description;

    public override string ToString()
    {
        var objId = Obj.SpdxId.ToString();
        return $"{Obj.GetType().Name}[{objId}].{PropertyName}: {Description}";
    }
}