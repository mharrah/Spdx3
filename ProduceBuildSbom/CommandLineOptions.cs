using System.CommandLine;

namespace ProduceBuildSbom;

public static class CommandLineOptions
{
    public static Option<string> OutputDir { get; } = new(name: "--outputDir", aliases: "-o")
    {
        Description = "The directory to write the file to",
        DefaultValueFactory = _ => new string(".")
    };

    public static Option<string> FileName { get; } = new(name: "--fileName", aliases: "-f")
    {
        Description = "The name of the output file",
        DefaultValueFactory = _ => "spdx3.sbom.build.json"
    };

    public static Option<string> SourceSbomPath { get; } = new(name: "--sourceSbomPath", aliases: "-p")
    {
        Description = "The path of the build SBOM to be enriched",
        DefaultValueFactory = _ => new string("."),
        Required = true
    };

    public static Option<bool> LiteDomainComplianceMandatory { get; } =
        new(name: "--liteDomainComplianceMandatory", aliases: "-l")
        {
            Description = "Fails if the document doesn't meet the minimum requirements of the Spdx 3.0 Lite Domain",
            DefaultValueFactory = _ => true
        };

    public static Option<bool> Verbose { get; } = new(name: "--verbose", aliases: "-v")
    {
        Description = "Writes commentary to stdout",
        DefaultValueFactory = _ => false
    };
    
    public static List<Option> All { get; } =
    [
        OutputDir,
        FileName,
        LiteDomainComplianceMandatory,
        Verbose,
        SourceSbomPath
    ];
}