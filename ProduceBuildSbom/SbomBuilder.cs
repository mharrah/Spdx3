using System.Xml;
using Spdx3.Model.Build.Classes;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.ExpandedLicensing.Classes;
using Spdx3.Model.Lite;
using Spdx3.Model.Software.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace ProduceBuildSbom;

public class SbomBuilder
{
    private Catalog Catalog { get; } = new();
    private CreationInfo CreationInfo { get; }

    public SbomBuilder()
    {
        CreationInfo = new CreationInfo(Catalog)
        {
            Created = DateTimeOffset.UtcNow,
        };
        CreationInfo.CreatedUsing.Add(new Tool(Catalog, CreationInfo)
        {
            Name = $"{nameof(ProduceBuildSbom)}",
            Description = "Demonstration project in the SPDX3 source " +
                          "repository that enhances the source SBOM to " +
                          "produce a build SBOM during the build phase."
        });
    }

    private static void EchoOptions()
    {
        if (!Program.Verbose)
        {
            return;
        }
        Console.WriteLine("Options in use:");
        Console.WriteLine($"OutputDir = {Program.OutputDir}");
        Console.WriteLine($"FileName = {Program.FileName}");
        Console.WriteLine($"SourceSbomPath = {Program.SourceSbomPath}");
        Console.WriteLine($"LiteDomainComplianceMandatory = {Program.LiteDomainComplianceMandatory}");
        Console.WriteLine($"Verbose = {Program.Verbose}");
    }

    public void EnrichSpdxDocumentWithBuildSbom()
    {
        EchoOptions();

        var reader = new Reader(Catalog);
        var spdxDocument = reader.ReadFileName(Program.SourceSbomPath);
        
        var gitHubServerUrl = Environment.GetEnvironmentVariable("GITHUB_SERVER_URL");
        var gitHubRepository = Environment.GetEnvironmentVariable("GITHUB_REPOSITORY");
        var gitHubRunId = Environment.GetEnvironmentVariable("GITHUB_RUN_ID");
        var build = new Build(Catalog, CreationInfo, new Uri($"{gitHubServerUrl}/{gitHubRepository}/actions/runs/{gitHubRunId}"))
            {
                BuildEndTime = DateTimeOffset.Now,
                BuildId = gitHubRunId
            };

        var buildSbom = new Sbom(Catalog, CreationInfo);
        buildSbom.SbomType.Add(SbomType.build);
        buildSbom.RootElement.Add(build);
        buildSbom.Element.Add(build);
        
        spdxDocument.RootElement.Add(buildSbom);
        spdxDocument.Element.Add(buildSbom);
        
        var writer = new Writer(Catalog);
        writer.WriteFileName(Path.Join(Program.OutputDir, Program.FileName));
    }
}