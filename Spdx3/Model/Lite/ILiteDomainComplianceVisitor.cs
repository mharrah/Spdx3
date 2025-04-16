using Spdx3.Model.Core.Classes;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Model.Software.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.Lite;

public interface ILiteDomainComplianceVisitor
{
    void Visit(SpdxDocument spdxDocument);
    void Visit(CreationInfo creationInfo);
    void Visit(Agent agent);
    void Visit(ExternalIdentifier externalIdentifier);
    void Visit(Hash hash);
    void Visit(NamespaceMap namespaceMap);
    void Visit(Relationship relationship);
    void Visit(LicenseExpression licenseExpression);
    void Visit(SimpleLicensingText simpleLicensingText);
    void Visit(Package package);
    void Visit(Sbom sbom);
}