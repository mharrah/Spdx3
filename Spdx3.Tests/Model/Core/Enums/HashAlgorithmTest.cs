using System.Text.Json;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Enums;

public class HashAlgorithmTest
{
    [Fact]
    public void HashAlgorithm_HasCorrect_Count()
    {
        Assert.Equal(22, Enum.GetValues(typeof(HashAlgorithm)).Length);
    }
}