namespace Spdx3.Model.Dataset.Enums;

/// <summary>
/// Enumeration of dataset types.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Dataset/Vocabularies/DatasetType/
/// </summary>
public enum DatasetType
{
    audio,
    categorical,
    graph,
    image,
    noAssertion,
    numeric,
    other,
    sensor,
    structured,
    syntactic,
    text,
    timeseries,
    timestamp,
    video
}