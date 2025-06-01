using System.CommandLine;

namespace ProduceSourceSbom;

/// <summary>
/// Executable console app entry point.
/// </summary>
internal class Program
{
    private static int Main(string[] args)
    {

        var rootCommand = new RootCommand("Produce Source Sbom for SPDX3");
        CommandLineOptions.All.ForEach(o => rootCommand.AddOption(o));
        rootCommand.TreatUnmatchedTokensAsErrors = true;
        
        rootCommand.SetHandler((outputDir, fileName, projectPath, verbose, liteDomainComplianceMandatory) =>
            {
                var sbomBuilder = new SbomBuilder()
                {
                    ProjectPath = projectPath
                };

                sbomBuilder.ProduceAllTheThings(outputDir, fileName, projectPath, verbose,
                    liteDomainComplianceMandatory);
            }, CommandLineOptions.OutputDir, CommandLineOptions.FileName,
            CommandLineOptions.ProjectPath, CommandLineOptions.Verbose,
            CommandLineOptions.LiteDomainComplianceMandatory);

        var invoke = rootCommand.Invoke(args);
        return invoke;
    }
}