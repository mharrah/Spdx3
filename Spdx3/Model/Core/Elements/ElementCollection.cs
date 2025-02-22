﻿using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Elements;

/// <summary>
/// A collection of Elements, not necessarily with unifying context.  An intermediate (abstract/base) class.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ElementCollection/
/// </summary>
public abstract class ElementCollection : Element
{
    private readonly IList<Element> _rootElement = new List<Element>();

    [JsonPropertyName("profileConformance")]
    public IList<ProfileIdentifierType> ProfileConformance { get; } = new List<ProfileIdentifierType>();

    /// <summary>
    /// Yep, the spec says one to many root elements. Go figure.
    /// </summary>
    [JsonPropertyName("rootElement")]
    public IList<Element> RootElement => _rootElement;

    [JsonPropertyName("element")]
    public IList<Element> Element { get; } = new List<Element>();


    [SetsRequiredMembers]
    protected ElementCollection(ISpdxIdFactory idFactory, string elementType, CreationInfo creationInfo) : base(idFactory, elementType, creationInfo)
    {
    }
}