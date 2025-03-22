using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Build;

public class BuildTest : BaseModelTest
{
    [Fact]
    public void BrandNew_Element_SerializesProperly()
    {
        // Arrange
        var element = new Spdx3.Model.Build.Classes.Build(TestCatalog, TestCreationInfo, new Uri("https://github.com"));
        const string expected = """
                                {
                                  "build_buildType": "https://github.com/",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "build_Build",
                                  "spdxId": "urn:Build:40f"
                                }
                                """;

        // Act
        var json = ToJson(element);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Element_SerializesProperly()
    {
        // Arrange
        var build = new Spdx3.Model.Build.Classes.Build(TestCatalog, TestCreationInfo, new Uri("https://github.com"))
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary",
            BuildStartTime = PredictableDateTime,
            BuildEndTime = PredictableDateTime,
            BuildId = "TestBuildId"
        };
        build.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        build.ExternalIdentifier.Add(
            new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));
        build.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.altDownloadLocation));
        build.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));
        build.ConfigSourceDigest.Add(new Hash(TestCatalog, HashAlgorithm.adler32, "hashval"));
        build.ConfigSourceEntrypoint.Add("TestEntryPoint");
        build.ConfigSourceUri.Add(new Uri("https://github.com"));
        build.Environment.Add(new DictionaryEntry(TestCatalog, "key", "val"));
        build.Parameter.Add(new DictionaryEntry(TestCatalog, "key", "val"));


        const string expected = """
                                {
                                  "build_buildEndTime": "2025-02-22T01:23:45Z",
                                  "build_buildId": "TestBuildId",
                                  "build_buildStartTime": "2025-02-22T01:23:45Z",
                                  "build_buildType": "https://github.com/",
                                  "build_configSourceDigest": [
                                    "urn:Hash:450"
                                  ],
                                  "build_configSourceEntrypoint": [
                                    "TestEntryPoint"
                                  ],
                                  "build_configSourceUri": [
                                    "https://github.com/"
                                  ],
                                  "build_environment": [
                                    "urn:DictionaryEntry:45d"
                                  ],
                                  "build_parameter": [
                                    "urn:DictionaryEntry:46a"
                                  ],
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "extension": [
                                    "urn:ExtensionConcreteTestFixture:41c"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:429"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:436"
                                  ],
                                  "name": "TestName",
                                  "summary": "TestSummary",
                                  "verifiedUsing": [
                                    "urn:IntegrityMethodConcreteTestFixture:443"
                                  ],
                                  "type": "build_Build",
                                  "spdxId": "urn:Build:40f"
                                }
                                """;

        // Act
        var json = ToJson(build);

        // Assert
        Assert.Equal(expected, json);
    }
}