using Spdx3.Model;
using Spdx3.Model.Build.Classes;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Extension.Classes;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Model.Software.Classes;
using Spdx3.Utility;
using File = System.IO.File;

namespace Spdx3.Tests.Utility;

public class IncompleteObjectFactoryTest
{
    [Fact]
    public static void TestDefaultConstructors()
    {
        Type[] modelClasses =
        [
            typeof(BaseModelClass),
            typeof(Annotation),
            typeof(Artifact),
            typeof(Bom),
            typeof(Bundle),
            typeof(CreationInfo),
            typeof(DictionaryEntry),
            typeof(Element),
            typeof(ElementCollection),
            typeof(ExternalIdentifier),
            typeof(ExternalMap),
            typeof(ExternalRef),
            typeof(Hash),
            typeof(IndividualElement),
            typeof(IntegrityMethod),
            typeof(LifecycleScopedRelationship),
            typeof(NamespaceMap),
            typeof(Organization),
            typeof(PackageVerificationCode),
            typeof(Person),
            typeof(PositiveIntegerRange),
            typeof(Relationship),
            typeof(SoftwareAgent),
            typeof(SpdxDocument),
            typeof(Tool),
            typeof(Build),
            typeof(CdxPropertiesExtension),
            typeof(CdxPropertyEntry),
            typeof(Extension),
            typeof(AnyLicenseInfo),
            typeof(LicenseExpression),
            typeof(SimpleLicensingText),
            typeof(ContentIdentifier),
            typeof(File),
            typeof(Package),
            typeof(Sbom),
            typeof(Snippet),
            typeof(SoftwareArtifact)
        ];

        foreach (var type in modelClasses.Where(t => !t.IsAbstract))
        {
            var method = typeof(IncompleteObjectFactory).GetMethod(nameof(IncompleteObjectFactory.Create));
            var generic = method.MakeGenericMethod(type);
            var t = generic.Invoke(null, null);
            Assert.NotNull(t);
            Assert.Equal(type, t.GetType());
        }
        
    }
}