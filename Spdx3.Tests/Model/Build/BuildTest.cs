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
        var element = new Spdx3.Model.Build.Classes.Build(TestSpdxCatalog, TestCreationInfo, new Uri("https://github.com"));
        const string expected = """
                                {
                                  "buildType": "https://github.com/",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "build_Build",
                                  "spdxId": "urn:Build:402"
                                }
                                """;

        // Act
        var json = element.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Element_SerializesProperly()
    {
        // Arrange
        var element = new Spdx3.Model.Build.Classes.Build(TestSpdxCatalog, TestCreationInfo, new Uri("https://github.com"))
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary",
            BuildStartTime = PredictableDateTime,
            BuildEndTime = PredictableDateTime,
            BuildId = "TestBuildId"
        };
        element.Extension.Add(new TestExtension(TestSpdxCatalog));
        element.ExternalIdentifier.Add(
            new ExternalIdentifier(TestSpdxCatalog, ExternalIdentifierType.email, "example@example.com"));
        element.ExternalRef.Add(new ExternalRef(TestSpdxCatalog, ExternalRefType.altDownloadLocation));
        element.VerifiedUsing.Add(new TestIntegrityMethod(TestSpdxCatalog));
        element.ConfigSourceDigest.Add(new Hash(TestSpdxCatalog, HashAlgorithm.adler32, "hashval"));
        element.ConfigSourceEntrypoint.Add("TestEntryPoint");
        element.ConfigSourceUri.Add(new Uri("https://github.com"));
        element.Environment.Add(new DictionaryEntry(TestSpdxCatalog, "key", "val"));
        element.Parameter.Add(new DictionaryEntry(TestSpdxCatalog, "key", "val"));


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
        var json = element.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

 }