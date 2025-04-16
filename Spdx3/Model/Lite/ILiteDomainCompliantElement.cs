namespace Spdx3.Model.Lite;

internal interface ILiteDomainCompliantElement
{
    internal void Accept(ILiteDomainComplianceVisitor visitor);
}