﻿using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A collection of Elements that have a shared context.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Bundle/
/// </summary>
public class Bundle : ElementCollection
{
    [JsonPropertyName("context")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<string> Context { get; } = new List<string>();

    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once MemberCanBeProtected.Global
    protected internal Bundle()
    {
    }

    [SetsRequiredMembers]
    public Bundle(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }
}