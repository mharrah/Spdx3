using System.Text.Json;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Enums;

public class RelationshipTypeTest
{
    [Fact]
    public void RelationshipType_HasCorrect_Count()
    {
        Assert.Equal(59, Enum.GetValues(typeof(RelationshipType)).Length);
    }
}