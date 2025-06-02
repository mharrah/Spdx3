using System.CommandLine;

namespace ProduceSourceSbom;

public static class CommandLineOptions
{
    public static Option<string> OutputDir { get; } = new (
        name: "--outputDir", 
        description: "The directory to write the file to",
        getDefaultValue: () => new string("."));

    public static Option<string> FileName{ get; } = new (
        name: "--fileName", 
        description: "The name of the output file",
        getDefaultValue: () => "spdx3.sbom.source.json");

    public static Option<string> ProjectPath { get; } = new (
        name: "--projectPath", 
        description: "The path of the .csproj file for SPDX3",
        getDefaultValue: () => new string("."));
    
    public static Option<bool> LiteDomainComplianceMandatory { get; }= new (
        name: "--liteDomainComplianceMandatory", 
        description: "Fails if the document doesn't meet the minimum requirements of the Spdx 3.0 Lite Domain",
        getDefaultValue: () => true);

    public static Option<bool> Verbose { get; } = new (
        name: "--verbose", 
        description: "Writes commentary to stdout",
        getDefaultValue: () => false);
    
    public static List<Option> All { get; } =
    [
        OutputDir,
        FileName,
        LiteDomainComplianceMandatory,
        Verbose,
        ProjectPath
    ];
    
    static CommandLineOptions()
    {
        OutputDir.AddAlias("-o");
        FileName.AddAlias("-f");
        LiteDomainComplianceMandatory.AddAlias("-l");
        Verbose.AddAlias("-v");
        ProjectPath.AddAlias("-p");
        ProjectPath.IsRequired = true;
    }
    
    
}