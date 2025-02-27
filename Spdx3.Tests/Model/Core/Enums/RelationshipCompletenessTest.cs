using System.Text.Json;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Enums;

public class RelationshipCompletenessTest
{
    [Fact]
    public void RelationshipCompleteness_HasCorrect_Count()
    {
        Assert.Equal(3, Enum.GetValues(typeof(RelationshipCompleteness)).Length);
    }
}