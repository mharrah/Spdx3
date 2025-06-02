using Spdx3.Model;

namespace Spdx3.Exceptions;

public class Spdx3ValidationException : Spdx3Exception
{
    public Spdx3ValidationException(BaseModelClass obj, string propertyName, string why) : base(FormatMessage(obj,
        propertyName, why))
    {
    }

    public Spdx3ValidationException(string message) : base(message)
    {
    }

    private static string FormatMessage(BaseModelClass obj, string propertyName, string why)
    {
        return $"Object {obj.GetType().Name}, property {propertyName}: {why}";
    }
}