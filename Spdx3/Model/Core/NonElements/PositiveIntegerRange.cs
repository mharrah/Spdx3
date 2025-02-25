using System.Text.Json.Serialization;
using Spdx3.Exceptions;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     A mapping between prefixes and namespace partial URIs.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/PositiveIntegerRange/
/// </summary>
public class PositiveIntegerRange : BaseSpdxClass
{
    private int? _beginIntegerRange;

    private int? _endIntegerRange;

    [JsonPropertyName("beginIntegerRange")]
    public int? BeginIntegerRange
    {
        get => _beginIntegerRange;
        set => _beginIntegerRange = value is null or < 1
            ? throw new Spdx3Exception("Invalid property value",
                new ArgumentOutOfRangeException(nameof(BeginIntegerRange),
                    $"Value of {value} must be a positive non-zero integer"))
            : value;
    }

    [JsonPropertyName("endIntegerRange")]
    public int? EndIntegerRange
    {
        get => _endIntegerRange;
        set => _endIntegerRange = value is null or < 1
            ? throw new Spdx3Exception("Invalid property value",
                new ArgumentOutOfRangeException(nameof(EndIntegerRange),
                    $"Value of {value} must be a positive non-zero integer"))
            : value;
    }

    public new void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(BeginIntegerRange));
        ValidateRequiredProperty(nameof(EndIntegerRange));
    }
}