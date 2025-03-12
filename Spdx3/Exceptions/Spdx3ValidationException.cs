using Spdx3.Model;

namespace Spdx3.Exceptions;

public class Spdx3ValidationException(BaseModelClass obj, string propertyName, string why) : Spdx3Exception(
    FormatMessage(obj,
        propertyName, why))
{
    private static string FormatMessage(BaseModelClass obj, string propertyName, string why)
    {
        return $"Object {obj.GetType().Name}, property {propertyName}: {why}";
    }
}