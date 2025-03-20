namespace Spdx3.Model.Dataset.Enums;

/// <summary>
/// Availability of dataset.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Dataset/Vocabularies/DatasetAvailabilityType/
/// </summary>
public enum DataAvailabilityType
{
    clickthrough,
    directDownload,
    query,
    registration,
    scrapingScript
}