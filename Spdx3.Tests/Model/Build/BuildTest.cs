using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Build;

public class BuildTest : BaseModelTestClass
{
   [Fact]
    public void BrandNew_Element_SerializesProperly()
    {
        // Arrange
        var element = new Spdx3.Model.Build.Classes.Build(TestCatalog, TestCreationInfo, new Uri("https://github.com"));
        const string expected = """
                                {
                                  "buildType": "https://github.com/",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "build_Build",
                                  "spdxId": "urn:Build:402"
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
        build.Extension.Add(new TestExtension(TestCatalog));
        build.ExternalIdentifier.Add(
            new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));
        build.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.altDownloadLocation));
        build.VerifiedUsing.Add(new TestIntegrityMethod(TestCatalog));
        build.ConfigSourceDigest.Add(new Hash(TestCatalog, HashAlgorithm.adler32, "hashval"));
        build.ConfigSourceEntrypoint.Add("TestEntryPoint");
        build.ConfigSourceUri.Add(new Uri("https://github.com"));
        build.Environment.Add(new DictionaryEntry(TestCatalog, "key", "val"));
        build.Parameter.Add(new DictionaryEntry(TestCatalog, "key", "val"));


        const string expected = """
                                {
                                  "buildEndTime": "2025-02-22T01:23:45Z",
                                  "buildId": "TestBuildId",
                                  "buildStartTime": "2025-02-22T01:23:45Z",
                                  "buildType": "https://github.com/",
                                  "configSourceDigest": [
                                    "urn:Hash:443"
                                  ],
                                  "configSourceEntrypoint": [
                                    "TestEntryPoint"
                                  ],
                                  "configSourceUri": [
                                    "https://github.com/"
                                  ],
                                  "environment": [
                                    "urn:DictionaryEntry:450"
                                  ],
                                  "configSourceUri": [
                                    "urn:DictionaryEntry:45d"
                                  ],
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "extension": [
                                    "urn:TestExtension:40f"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:41c"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:429"
                                  ],
                                  "name": "TestName",
                                  "summary": "TestSummary",
                                  "verifiedUsing": [
                                    "urn:TestIntegrityMethod:436"
                                  ],
                                  "type": "build_Build",
                                  "spdxId": "urn:Build:402"
                                }
                                """;

        // Act
        var json = ToJson(build);

        // Assert
        Assert.Equal(expected, json);
    }

 }