using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.Experiment;

public class RunMe
{
    [Fact]
    public void TryIt()
    {
        var factory = new SpdxClassFactory();
        var outer = factory.New<Outer>();
        outer.Inners.Add(factory.New<Inner>());
        outer.Inners.Add(factory.New<Inner>());
        outer.Inners.Add(factory.New<Inner>());

        var options = new JsonSerializerOptions()
        {
            WriteIndented = true,
            TypeInfoResolver = new DefaultJsonTypeInfoResolver
            {
                Modifiers = { IgnoreEmptyCollections.Modifier }
            }
        };
        options.Converters.Add(new SpdxCollectionConvertorFactory());

        // ReSharper disable once SuggestVarOrType_BuiltInTypes
        object o = outer;
        // ReSharper disable once RedundantTypeArgumentsOfMethod
        var json = JsonSerializer.Serialize<object>(o, options);

        Assert.Equal("""
                     {
                       "inners": [
                         "urn:Inner:402",
                         "urn:Inner:40f",
                         "urn:Inner:41c"
                       ],
                       "comment": "Outer comment",
                       "type": "Outer",
                       "spdxId": "urn:Outer:3f5"
                     }
                     """, json);
    }
}