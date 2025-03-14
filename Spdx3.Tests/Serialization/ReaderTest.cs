using System.Reflection;
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
        var json = File.ReadAllText(jsonFile);

        // Act
        var catalog = new Catalog();
        var spdxDocument = new Reader(catalog).ReadFileName(jsonFile);
        
        // Assert
        Assert.NotNull(spdxDocument);
        Assert.NotEmpty(spdxDocument.Element);
        Assert.Equal(2,spdxDocument.ProfileConformance.Count);
    } 
        
        
    private static string GetTestFilePath(string relativePath)
    {
        var codeBaseUrl = new Uri(Assembly.GetExecutingAssembly().Location);
        var codeBasePath = Uri.UnescapeDataString(codeBaseUrl.AbsolutePath);
        var dirPath = Path.GetDirectoryName(codeBasePath);
        return Path.Combine(dirPath, "TestFiles", relativePath);
    }
}