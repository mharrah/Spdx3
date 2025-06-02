$temp = $env:TEMP
if (-not $temp) {
    $temp = [System.IO.Path]::GetTempPath()
}
$fn = Join-Path "$temp" "license-list-data"

if (-not (Test-Path "$fn.zip")) {
    Invoke-WebRequest -Uri "https://github.com/spdx/license-list-data/archive/refs/heads/main.zip" -OutFile "$fn.zip"
}
if (-not (Test-Path $fn)) {
    Expand-Archive -Path "$fn.zip" -DestinationPath $fn
}


$classes = [ordered]@{}
$classNamesForLicenseIDs = [ordered]@{}
$licenses = (Get-Content "$fn/license-list-data-main/json/licenses.json") | ConvertFrom-Json 
$i = 0
foreach ($license in ($licenses.licenses | Sort-Object licenseId)) {
    $i++
    $pct = 100 * $i / $licenses.licenses.Count
    Write-Progress -Id 0 -Activity "Scanning" -Status "Processing $($license.licenseId)..." -PercentComplete $pct

    $lspec = (Get-Content "$fn/license-list-data-main/SPDXv3/v3jsonld/$($license.licenseId).json") | ConvertFrom-Json

    $details = $lspec."@graph" | Where-Object type -eq 'expandedlicensing_ListedLicense'

    $seeAlsoUrls = @()
    foreach ($u in $details.expandedlicensing_seeAlso | Sort-Object -Unique) {
        $seeAlsoUrls += "`n            new Uri(""$u"")"
    }

    $className = $license.licenseId -replace "[^A-Za-z0-9]", '_'
    if ($className -match "^[^A-Za-z]" ) {
        $className = "_$className"
    }
    $className = $className.ToUpper()

    $classNamesForLicenseIDs[$license.licenseId] = $className
    
    $classCode = @"

    public static readonly ListedLicense $className = new ListedLicense
    {
        SpdxId = new Uri("$($details.spdxId)"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ $($seeAlsoUrls -join ',')
        ],
        LicenseText = ReadResource("$($license.licenseId).fulltext.txt"),  
"@

    Set-Content -Path "$PSScriptRoot/Spdx3/LicenseData/$($license.licenseId).fulltext.txt" -Value $details.simplelicensing_licenseText

    if ($details.expandedlicensing_standardLicenseTemplate) {
        $classCode += "`n        StandardLicenseTemplate = ReadResource(""$($license.licenseId).template.txt""),"
        Set-Content -Path "$PSScriptRoot/Spdx3/LicenseData/$($license.licenseId).template.txt" -Value $details.expandedlicensing_standardLicenseTemplate
    }
    if ($details.expandedlicensing_standardLicenseHeader) {
        $classCode += "`n        StandardLicenseHeader = ReadResource(""$($license.licenseId).header.txt""),"
        Set-Content -Path "$PSScriptRoot/Spdx3/LicenseData/$($license.licenseId).header.txt" -Value $details.expandedlicensing_standardLicenseHeader
    }
    if ($details.comment) {
        $classCode += "`n        Comment = ""$($details.comment -replace '\\', '\\' -replace '"', '\"' -replace '\n', '\n')"","
    }
    if ($details.expandedlicensing_isFsfLibre) {
        $classCode += "`n        IsFsfLibre = $($details.expandedlicensing_isFsfLibre.ToString().ToLower()),"
    }
    if ($details.expandedlicensing_isFsfLibre) {
        $classCode += "`n        IsOsiApproved = $($details.expandedlicensing_isOsiApproved.ToString().ToLower()),"
    }
    if ($details.expandedlicensing_isDeprecatedLicenseId) {
        $classCode += "`n        IsDeprecatedLicenseId = $($details.expandedlicensing_isDeprecatedLicenseId.ToString().ToLower()),"
    }
    if ($details.expandedlicensing_deprecatedVersion) {
        $classCode += "`n        DeprecatedVersion = ""$($details.expandedlicensing_deprecatedVersion)"","
    }
    if ($details.expandedlicensing_obsoletedBy) {
        $classCode += "`n        ObsoletedBy = ""$($details.expandedlicensing_obsoletedBy)"","
    }
    if ($details.description) {
        $classCode += "`n        Description = ""$($details.description -replace '\\', '\\' -replace '"', '\"' -replace '\n', '\n')"","
    }


    $classCode += "`n        Catalog = _creationInfo.Catalog,";
    $classCode += "`n        CreationInfo = _creationInfo";
    $classCode += "`n    };";
    $classes["$($license.licenseId)"] = $classCode


#    if ($classes.count -ge 50) {
#        break;
#    }


}
Write-Progress -Id 0 -Activity "Scanning" -Completed


$dictionaryContents = @()
foreach ($entry in $classNamesForLicenseIDs.GetEnumerator()) {
    $dictionaryContents += "`n        { ""$($entry.Key)"", $($entry.Value) }"
}


$fn = "$PSScriptRoot/Spdx3/Model/ExpandedLicensing/Classes/ListedLicenses.cs"

Set-Content -Path $fn  -Value @"
using System.Globalization;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.ExpandedLicensing.Classes;

public class ListedLicenses
{
    private static readonly CreationInfo _creationInfo =
        new(new Catalog(),
                DateTimeOffset.ParseExact("$([DateTimeOffset]::UtcNow.ToString("o"))", "o", new DateTimeFormatInfo()))
            { SpdxId = new Uri("https://github.com/mharrah/Spdx3/ListedListedLicenses") };

$($classes.Values)

    public readonly static Dictionary<string, ListedLicense> Licenses = new Dictionary<string, ListedLicense>
    { $($dictionaryContents -join ",")
    };


    private static string ReadResource(string name)
    {
        // Determine path
        var assembly = System.Reflection.Assembly.GetExecutingAssembly();
        var resources = assembly.GetManifestResourceNames();
        var resourcePath = resources.Single(str => str == $"Spdx3.LicenseData.{name}");

        using var stream = assembly.GetManifestResourceStream(resourcePath);
        using var reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }
}
"@
