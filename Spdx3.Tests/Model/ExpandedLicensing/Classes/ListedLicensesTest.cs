using Spdx3.Model.ExpandedLicensing.Classes;

namespace Spdx3.Tests.Model.ExpandedLicensing.Classes;

public class ListedLicensesTest
{
    [Fact]
    public void ListedLicenses_HavePopulatedFields()
    {
        // Arrange
        var mitLicense = ListedLicenses.MIT;

        // Assert
        Assert.NotNull(mitLicense);
        Assert.StartsWith("MIT License", mitLicense.LicenseText);
    }
}