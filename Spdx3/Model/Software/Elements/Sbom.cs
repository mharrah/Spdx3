﻿using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.NonElements;
using Spdx3.Model.Software.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Elements;

public class Sbom : Bom
{
    [SetsRequiredMembers]
    public Sbom(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory, creationInfo)
    {
    }

    [JsonPropertyName("sbomType")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<SbomType> SbomType { get; } = new List<SbomType>();
}