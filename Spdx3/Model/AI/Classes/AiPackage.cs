using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.AI.Enums;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.AI.Classes;

public class AiPackage : Package
{
    
    [JsonPropertyName("releaseTime")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public new required DateTimeOffset ReleaseTime { get; set; }
    
    [JsonPropertyName("suppliedBy")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public new required Agent SuppliedBy { get; set; }

    [JsonPropertyName("software_downloadLocation")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public new required Uri DownloadLocation { get; set; }

    [JsonPropertyName("software_packageVersion")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public new required string PackageVersion { get; set; }

    [JsonPropertyName("software_primaryPurpose")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public new required SoftwarePurpose PrimaryPurpose { get; set; }
    
    [JsonPropertyName("ai_autonomyType")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public PresenceType? AutonomyType { get; set; }

    [JsonPropertyName("ai_domain")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<string> Domain { get; set; } = new List<string>();

    [JsonPropertyName("ai_energyConsumption")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public EnergyConsumption? EnergyConsumption { get; set; }

    [JsonPropertyName("ai_hyperparameter")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<DictionaryEntry> HyperParameter { get; set; } = new List<DictionaryEntry>();

    [JsonPropertyName("ai_informationAboutApplication")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? InformationAboutApplication { get; set; }

    [JsonPropertyName("ai_informationAboutTraining")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? InformationAboutTraining { get; set; }

    [JsonPropertyName("ai_limitation")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? Limitation { get; set; }

    [JsonPropertyName("ai_metric")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<DictionaryEntry> Metric { get; set; } = new List<DictionaryEntry>();

    [JsonPropertyName("ai_metricDecisionThreshold")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<DictionaryEntry> MetricDecisionThreshold { get; set; } = new List<DictionaryEntry>();

    [JsonPropertyName("ai_modelDataPreprocessing")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<string> ModelDataPreprocessing { get; set; } = new List<string>();

    [JsonPropertyName("ai_modelExplainability")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<string> ModelExplainability { get; set; } = new List<string>();

    [JsonPropertyName("ai_safetyRiskAssessment")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public SafetyRiskAssessmentType? SafetyRiskAssessment { get; set; }

    [JsonPropertyName("ai_standardCompliance")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<string> StandardCompliance { get; set; } = new List<string>();

    [JsonPropertyName("ai_typeOfModel")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<string> TypeOfModel { get; set; } = new List<string>();

    [JsonPropertyName("ai_useSensitivePersonalInformation")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public PresenceType? UseSensitivePersonalInformation { get; set; }

    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal AiPackage()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public AiPackage(Catalog catalog, 
        CreationInfo creationInfo, 
        DateTimeOffset releaseTime, 
        Agent suppliedBy,
        Uri downloadLocation, 
        string packageVersion, 
        SoftwarePurpose primaryPurpose) : base(catalog, creationInfo)
    {
        this.ReleaseTime = releaseTime;
        this.SuppliedBy = suppliedBy;
        this.DownloadLocation = downloadLocation;
        this.PackageVersion = packageVersion;
        this.PrimaryPurpose = primaryPurpose;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(ReleaseTime));
        ValidateRequiredProperty(nameof(SuppliedBy));
        ValidateRequiredProperty(nameof(DownloadLocation));
        ValidateRequiredProperty(nameof(PackageVersion));
        ValidateRequiredProperty(nameof(PrimaryPurpose));
    }
}