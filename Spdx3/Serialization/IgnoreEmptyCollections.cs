using System.Text.Json.Serialization.Metadata;

namespace Spdx3.Serialization;

/// <summary>
/// This is a class that contains a Modifier method that can be used to ignore empty collections and null values when serializing objects into Json.
/// </summary>
public static class IgnoreEmptyCollections
{
    public static void Modifier(JsonTypeInfo typeInfo)
    {
        foreach (var propertyInfo in typeInfo.Properties)
        {
            Console.Write("Serializing...");
            
            // ReSharper disable once UnusedParameter.Local
            propertyInfo.ShouldSerialize = (obj, val) =>
            {
                // Never serialize null properties
                if (val == null)
                {
                    return false;
                }

                // If it's a collection, and it's empty, don't serialize it
                var countProperty = val.GetType().GetProperty("Count");
                if (countProperty == null) return true;
                
                var v = countProperty.GetValue(val);
                var count = (int?)v;
                return count != 0;
            };
        }
    }
}