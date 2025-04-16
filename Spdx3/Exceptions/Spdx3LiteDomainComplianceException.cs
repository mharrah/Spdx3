namespace Spdx3.Exceptions;

public class Spdx3LiteDomainComplianceException : Spdx3ValidationException
{
    public Spdx3LiteDomainComplianceException(string objectName, string fieldName, string problem) : base(
        message: $"{objectName}.{fieldName}: {problem}")
    {
    }

}