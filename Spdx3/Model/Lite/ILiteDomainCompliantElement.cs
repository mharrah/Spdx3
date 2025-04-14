namespace Spdx3.Model.Lite;

public interface ILiteDomainCompliantElement
{
    public void Accept(ILiteDomainComplianceVisitor visitor);
}