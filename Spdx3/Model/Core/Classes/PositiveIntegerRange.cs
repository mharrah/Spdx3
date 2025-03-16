using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A mapping between prefixes and namespace partial URIs.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/PositiveIntegerRange/
/// </summary>
public class PositiveIntegerRange : BaseModelClass
{
    private int _beginIntegerRange = 1;

    private int _endIntegerRange = int.MaxValue;

    [JsonPropertyName("beginIntegerRange")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required int BeginIntegerRange
    {
        get => _beginIntegerRange;
        set
        {
            if (value < 1)
            {
                throw new Spdx3Exception($"Value of {value} is not a positive non-zero integer",
                    new ArgumentOutOfRangeException(nameof(BeginIntegerRange)));
            }

            if (value > _endIntegerRange)
            {
                throw new Spdx3Exception($"Value of {value} cannot exceed end integer value of {_endIntegerRange}",
                    new ArgumentOutOfRangeException(nameof(BeginIntegerRange)));
            }

            _beginIntegerRange = value;
        }
    }


    [JsonPropertyName("endIntegerRange")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required int EndIntegerRange
    {
        get => _endIntegerRange;
        set
        {
            if (value < 1)
            {
                throw new Spdx3Exception($"Value of {value} is not a positive non-zero integer",
                    new ArgumentOutOfRangeException(nameof(EndIntegerRange)));
            }

            if (value < _beginIntegerRange)
            {
                throw new Spdx3Exception(
                    $"Value of {value} cannot be less than begin integer value of {_beginIntegerRange}",
                    new ArgumentOutOfRangeException(nameof(EndIntegerRange)));
            }

            _endIntegerRange = value;
        }
    }

    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once UnusedMember.Global
    protected internal PositiveIntegerRange()
    {
    }

    [SetsRequiredMembers]
    public PositiveIntegerRange(Catalog catalog, int beginIntegerRange, int endIntegerRange) : base(
        catalog)
    {
        if (beginIntegerRange < 1)
        {
            throw new Spdx3Exception("beginIntegerRange must be a positive, non-zero integer");
        }

        if (endIntegerRange < beginIntegerRange)
        {
            throw new Spdx3Exception("endIntegerRange must be >= beginIntegerRange");
        }

        BeginIntegerRange = beginIntegerRange;
        EndIntegerRange = endIntegerRange;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(BeginIntegerRange));
        ValidateRequiredProperty(nameof(EndIntegerRange));
    }
}