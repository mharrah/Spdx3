using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     A mapping between prefixes and namespace partial URIs.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/PositiveIntegerRange/
/// </summary>
public class PositiveIntegerRange : BaseSpdxClass
{
    private int _beginIntegerRange;

    private int _endIntegerRange;

    [SetsRequiredMembers]
    public PositiveIntegerRange(SpdxIdFactory spdxIdFactory, int beginIntegerRange, int endIntegerRange) : base(
        spdxIdFactory)
    {
        if (beginIntegerRange < 1)
        {
            throw new Spdx3Exception("beginIntegerRange must be a positive, non-zero integer");
        }
        if (endIntegerRange <= beginIntegerRange)
        {
            throw new Spdx3Exception("endIntegerRange must be >= beginIntegerRange");
        }
        BeginIntegerRange = beginIntegerRange;
        EndIntegerRange = endIntegerRange;
    }

    [JsonPropertyName("beginIntegerRange")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required int BeginIntegerRange
    {
        get => _beginIntegerRange;
        set => _beginIntegerRange = value < 1
            ? throw new Spdx3Exception("Invalid property value",
                new ArgumentOutOfRangeException(nameof(BeginIntegerRange),
                    $"Value of {value} must be a positive non-zero integer"))
            : value;
    }

    [JsonPropertyName("endIntegerRange")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required int EndIntegerRange
    {
        get => _endIntegerRange;
        set => _endIntegerRange = value < 1
            ? throw new Spdx3Exception("Invalid property value",
                new ArgumentOutOfRangeException(nameof(EndIntegerRange),
                    $"Value of {value} must be a positive non-zero integer"))
            : value;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(BeginIntegerRange));
        ValidateRequiredProperty(nameof(EndIntegerRange));
    }
}