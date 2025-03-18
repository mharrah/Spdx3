using Spdx3.Exceptions;
using Spdx3.Model;
using Spdx3.Model.Build.Classes;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Extension.Classes;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Model.Software.Classes;
using Spdx3.Utility;
using File = Spdx3.Model.Software.Classes.File;


namespace Spdx3.Tests.Utility;

public class IncompleteObjectFactoryTest
{
    [Fact]
    public static void TestDefaultConstructors_And_Validators()
    {
        // Arrange
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
            // Act
            var method = typeof(IncompleteObjectFactory).GetMethod(nameof(IncompleteObjectFactory.Create))
                         ?? throw new Spdx3Exception(
                             $"Could not find {nameof(IncompleteObjectFactory.Create)} method on {typeof(IncompleteObjectFactory)}");
            var generic = method.MakeGenericMethod(type);
            var t = generic.Invoke(null, null) as BaseModelClass;
            
            // Assert
            Assert.NotNull(t);
            Assert.Equal(type, t.GetType());
            
            
            // Act again
            var exception = Record.Exception(() => t.Validate()); 

            // Assert again
            Assert.NotNull(exception);
        }
        
    }
}