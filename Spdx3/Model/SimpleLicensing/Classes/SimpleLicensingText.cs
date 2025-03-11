using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.SimpleLicensing.Classes;

/// <summary>
/// A license or addition that is not listed on the SPDX License List.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/SimpleLicensing/Classes/SimpleLicensingText/
/// </summary>
public class SimpleLicensingText : Element
{
    // protected internal no-parm constructor required for deserialization
    protected internal SimpleLicensingText()
    {
    }
    
    [SetsRequiredMembers]
    public SimpleLicensingText(SpdxCatalog spdxCatalog, CreationInfo creationInfo, string licenseText) : base(spdxCatalog, creationInfo)
    {
        LicenseText = licenseText;
    }

    [JsonPropertyName("licenseText")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required string LicenseText { get; set; }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(LicenseText));
    }
}