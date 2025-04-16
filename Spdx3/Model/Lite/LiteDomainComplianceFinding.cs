using System.Globalization;

namespace Spdx3.Model.Lite;

public class LiteDomainComplianceFinding
{
    public readonly BaseModelClass Obj;
    public readonly string? PropertyName;
    public readonly string Description;
    public readonly LiteDomainComplianceFindingType FindingType;

    public LiteDomainComplianceFinding(LiteDomainComplianceFindingType findingType, BaseModelClass obj, string propertyName, string description)
    {
        Obj = obj;
        PropertyName = propertyName;
        Description = description;
        FindingType = findingType;
    }

    public LiteDomainComplianceFinding(LiteDomainComplianceFindingType findingType, BaseModelClass obj, string description)
    {
        Obj = obj;
        PropertyName = null;
        Description = description;
        FindingType = findingType;
    }

    
    public override string ToString()
    {
        var objType = Obj.GetType().Name;
        var objId = Obj.SpdxId.ToString();
        var level = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(FindingType.ToString());
        var prop = PropertyName is null ? "" : $".{PropertyName}";
        return $"{level}: {objType}[{objId}]{prop}: {Description}";
    }
}