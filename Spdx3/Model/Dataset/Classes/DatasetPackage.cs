using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Dataset.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Dataset.Classes;

/// <summary>
/// Specifies a data package and its associated information.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Dataset/Classes/DatasetPackage/
/// </summary>
public class DatasetPackage : Package
{
    [JsonPropertyName("dataset_anonymizationMethodUsed")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<string> AnonymizationMethodUsed { get; set; } = new List<string>();
    
    [JsonPropertyName("dataset_confidentialityLevel")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public ConfidentialityLevelType? ConfidentialityLevel { get; set; }   
        
    [JsonPropertyName("dataset_dataCollectionProcess")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? DataCollectionProcess { get; set; }
    
    [JsonPropertyName("dataset_dataPreprocessing")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<string> DataPreprocessing { get; set; } = new List<string>();

    [JsonPropertyName("dataset_datasetAvailability")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public DataAvailabilityType? DataAvailabilityType { get; set; }

    [JsonPropertyName("dataset_datasetNoise")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? DatasetNoise { get; set; }

    private int? _datasetSize;
    [JsonPropertyName("dataset_datasetSize")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public int? DatasetSize
    {
        get => _datasetSize; 
        set
        {
            switch (value)
            {
                case < 0:
                    throw new Spdx3Exception($"Value of {value} is not a positive non-zero integer",
                        new ArgumentOutOfRangeException(nameof(DatasetSize)));
                case null:
                    _datasetSize = null;
                    break;
                default:
                    _datasetSize = value;
                    break;
            }
        }

    }
    
    [JsonPropertyName("dataset_datasetType")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<DatasetType> DatasetType { get; set; } = new List<DatasetType>();
    
    [JsonPropertyName("dataset_datasetUpdateMechanism")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? DatasetUpdateMechanism { get; set; }
    
    [JsonPropertyName("dataset_hasSensitivePersonalInformation")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public PresenceType? HasSensitivePersonalInformation { get; set; }
    
    [JsonPropertyName("dataset_intendedUse")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? IntendedUse { get; set; }
    
    [JsonPropertyName("dataset_knownBias")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? KnownBias { get; set; }
    
    [JsonPropertyName("dataset_sensor")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<DictionaryEntry> Sensor { get; set; } = new List<DictionaryEntry>();
    
    
    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once UnusedMember.Global
    protected internal DatasetPackage()
    {
    }

    [SetsRequiredMembers]
    public DatasetPackage(Catalog catalog, CreationInfo creationInfo, IList<DatasetType> datasetTypes) : base(catalog, creationInfo)
    {
        if (datasetTypes.Count == 0)
        {
            throw new ArgumentException($"{nameof(datasetTypes)} list needs to contain at least one dataset type value");
        }
        DatasetType = new List<DatasetType>();
        datasetTypes.ToList().ForEach(ds => DatasetType.Add(ds));
    }

    public override void Validate()
    {
        base.Validate();
        if (DatasetType?.Count == 0)
        {
            throw new Spdx3ValidationException(this, nameof(DatasetType), "List is empty");
        }
    }
}