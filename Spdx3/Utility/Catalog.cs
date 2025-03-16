using System.Collections;
using Spdx3.Exceptions;
using Spdx3.Model;
using Spdx3.Model.Core.Classes;

namespace Spdx3.Utility;

/// <summary>
///     A class that tracks objects created and helps make ID's for new objets.
/// </summary>
public class Catalog
{
    // start at 1000 so the generated numbers are at least 3 characters long and will usually look like hex numbers when rendered
    private int _idCounter = 1000;

    // A running list of all the objects created 
    public IDictionary<string, BaseModelClass> Items { get; } = new Dictionary<string, BaseModelClass>();

    /// <summary>
    ///     There's no semantic meaning to an SPDX ID, and no real correspondence to real life objects.
    ///     It's just an element identifier used within the document, so things can reference each other.
    /// </summary>
    /// <param name="type">The type of object to create an ID for</param>
    /// <returns>A URN that can be used as a node identifier (spdxId)</returns>
    public string NewId(Type type)
    {
        return $"urn:{type.Name}:{GetShortUid()}";
    }

    private string GetShortUid()
    {
        // add 13 each time so the numbers look more different from each other and don't look like an incrementing counter
        return (_idCounter += 13).ToString("x");
    }

    /// <summary>
    /// Reconstruct a model object graph from the flat list of items in the catalog
    /// </summary>
    /// <returns>The SpdxDocument that is the top-level element in the document</returns>
    /// <exception cref="Spdx3SerializationException">If there is not exactly one SpdxDocument element in the catalog</exception>
    public SpdxDocument GetModel()
    {
        var spdxDocs = Items.Values.ToList().Where(x => x.Type == "SpdxDocument").ToList();
        if (spdxDocs.Count != 1)
        {
            throw new Spdx3SerializationException($"Expected exactly one SpdxDocument, but got {spdxDocs.Count}.");
        }
        var result = (SpdxDocument) spdxDocs.First();

        // Replace all placeholders with their real objects
        foreach (var item in Items.Values.ToList())
        {
            var props = item.GetType().GetProperties();
            foreach (var prop in props)
            {
                if (prop.GetValue(item) == null)
                {
                    continue;
                }
                
                var isSpdxClass = prop.PropertyType.IsAssignableTo(typeof(BaseModelClass));
                var isListOfSpdxClass = prop.PropertyType.IsGenericType
                                        && prop.PropertyType.GetGenericTypeDefinition() == typeof(IList<>)
                                        && prop.PropertyType.GetGenericArguments()[0].IsAssignableTo(typeof(BaseModelClass));

                if (isSpdxClass)
                {
                    var placeHolder = (BaseModelClass)prop.GetValue(item);
                    if (placeHolder == null)
                    {
                        continue;
                    }

                    if (Items.TryGetValue(placeHolder.SpdxId, out var value))
                    {
                        prop.SetValue(item, value);
                    }
                }

                if (!isListOfSpdxClass)
                {
                    continue;
                }
                
                var listOfPlaceHolders = (IList)prop.GetValue(item);
                if (listOfPlaceHolders.Count == 0)
                {
                    continue;
                }
                var listOfReplacements = new List<BaseModelClass>();
                foreach (var ph in listOfPlaceHolders)
                {
                    var placeHolder = (BaseModelClass)ph;
                    if (!Items.TryGetValue(placeHolder.SpdxId, out var value))
                    {
                        throw new Spdx3SerializationException($"Unable to find catalog entry with matching ID {placeHolder.SpdxId}");
                    }

                    listOfReplacements.Add(value);
                }
                listOfPlaceHolders.Clear();
                listOfReplacements.ForEach(r => listOfPlaceHolders.Add(r));
                
            }
        }
        
        foreach (var baseModelClass in Items.Values.ToList())
        {
            if (baseModelClass is Element e)
            {
                result.Element.Add(e);
            }
        }
        return result;
    }
}