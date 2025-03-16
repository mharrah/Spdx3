using System.Reflection;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Tests.Serialization;

public class ReaderTest
{
    [Fact]
    public void Reader_ReadsJsonFile()
    {
        // Arrange
        var jsonFile = GetTestFilePath("Acme Application.spdx3.0.1.json");

        // Act
        var catalog = new Catalog();
        var spdxDocument = new Reader(catalog).ReadFileName(jsonFile);
        
        // Assert
        Assert.Equal(18, catalog.Items.Count);
        Assert.Equal(4, catalog.Items.Values.Count(i => i.Type == "Relationship"));
        Assert.Equal(2, catalog.Items.Values.Count(i => i.Type == "Organization"));
        Assert.Equal(2, catalog.Items.Values.Count(i => i.Type == "Person"));
        
        Assert.NotNull(spdxDocument);
        Assert.NotEmpty(spdxDocument.Element);
        Assert.Equal(2,spdxDocument.ProfileConformance.Count);

        var creationInfo = (CreationInfo)catalog.Items.Values.First(v => v.Type == "CreationInfo");
        Assert.Equal(creationInfo, spdxDocument.CreationInfo);
        Assert.Equal(new DateTimeOffset( 2024, 5, 2, 0, 0, 0, TimeSpan.Zero), creationInfo.Created);
    } 
        
        
    private static string GetTestFilePath(string relativePath)
    {
        var codeBaseUrl = new Uri(Assembly.GetExecutingAssembly().Location);
        var codeBasePath = Uri.UnescapeDataString(codeBaseUrl.AbsolutePath);
        var dirPath = Path.GetDirectoryName(codeBasePath);
        return Path.Combine(dirPath ?? throw new Spdx3SerializationException("Could not find test file directory"), "TestFiles", relativePath);
    }
}