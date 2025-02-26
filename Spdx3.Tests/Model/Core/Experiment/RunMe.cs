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
        outer.Middles.Add(factory.New<Middle>());
        outer.Middles.Add(factory.New<Middle>());

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
                       "middles": [
                         "urn:Middle:402",
                         "urn:Middle:40f"
                       ],
                       "comment": "Outer comment",
                       "type": "Outer",
                       "spdxId": "urn:Outer:3f5"
                     }
                     """, json);
    }
}