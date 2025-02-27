using System.Text.Json;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Enums;

public class AnnotationTypeTest
{
    [Fact]
    public void AnnotationType_HasCorrect_Count()
    {
        Assert.Equal(2, Enum.GetValues(typeof(AnnotationType)).Length);
    }
}