using Spdx3.Model;

namespace Spdx3.Utility;

public class LiteDomainComplianceProblem(IModelClass obj, string propertyName, string description)
{
    public readonly IModelClass Obj = obj;
    public readonly string PropertyName = propertyName;
    public readonly string Description = description;

    public override string ToString()
    {
        var objId = Obj.SpdxId.ToString();
        return $"{Obj.GetType().Name}[{objId}].{PropertyName}: {Description}";
    }
}