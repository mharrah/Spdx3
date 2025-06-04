using System.CommandLine;

namespace ProduceBuildSbom;

/// <summary>
/// Executable console app entry point.
/// </summary>
internal class Program
{
    public static bool Verbose { get; private set; }
    public static string SourceSbomPath { get; private set; } = new string(string.Empty);
    public static string OutputDir { get; private set; } = new string(string.Empty);
    public static string FileName { get; private set; } = new string(string.Empty);
    public static bool LiteDomainComplianceMandatory { get; private set; }
    
    private static int Main(string[] args)
    {

        var rootCommand = new RootCommand("Produce Source Sbom for SPDX3");
        CommandLineOptions.All.ForEach(o => rootCommand.AddOption(o));
        rootCommand.TreatUnmatchedTokensAsErrors = true;
        
        rootCommand.SetHandler((outputDir, fileName, sourceSbomPath, verbose, liteDomainComplianceMandatory) =>
            {
                Verbose = verbose;
                SourceSbomPath = sourceSbomPath;
                OutputDir = outputDir;
                FileName = fileName;
                LiteDomainComplianceMandatory = liteDomainComplianceMandatory;
            }, CommandLineOptions.OutputDir, CommandLineOptions.FileName,
            CommandLineOptions.SourceSbomPath, CommandLineOptions.Verbose,
            CommandLineOptions.LiteDomainComplianceMandatory);

        var invoke = rootCommand.Invoke(args);
        if (invoke != 0) return invoke;
        
        var sbomBuilder = new SbomBuilder();
        sbomBuilder.EnrichSpdxDocumentWithBuildSbom();

        return 0;
    }
}