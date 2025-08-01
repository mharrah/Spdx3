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
        CommandLineOptions.All.ForEach(o => rootCommand.Options.Add(o));
        rootCommand.TreatUnmatchedTokensAsErrors = true;

        ParseResult parseResult = rootCommand.Parse(args);
        Verbose = parseResult.GetValue(CommandLineOptions.Verbose);
        SourceSbomPath = parseResult.GetValue(CommandLineOptions.SourceSbomPath);
        OutputDir = parseResult.GetValue(CommandLineOptions.OutputDir);
        FileName = parseResult.GetValue(CommandLineOptions.FileName);
        LiteDomainComplianceMandatory = parseResult.GetValue(CommandLineOptions.LiteDomainComplianceMandatory);

        var sbomBuilder = new SbomBuilder();
        sbomBuilder.EnrichSpdxDocumentWithBuildSbom();

        return 0;
    }
}