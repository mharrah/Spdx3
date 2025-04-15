using System.Reflection;
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
    public IDictionary<Uri, BaseModelClass> Items { get; } = new Dictionary<Uri, BaseModelClass>();

    /// <summary>
    ///     There's no semantic meaning to an SPDX ID, and no real correspondence to real life objects.
    ///     It's just an element identifier used within the document, so things can reference each other.
    /// </summary>
    /// <param name="type">The type of object to create an ID for</param>
    /// <returns>A URN that can be used as a node identifier (spdxId)</returns>
    public Uri NewId(Type type)
    {
        return new Uri($"urn:{type.Name}:{GetShortUid()}");
    }

    /// <summary>
    ///     Get the one SpdxDocument object from the catalog
    /// </summary>
    /// <returns>The one SpdxDocument</returns>
    /// <exception cref="Spdx3Exception">If not exactly one SpdxDocument could be found.</exception>
    public SpdxDocument GetSpdxDocument()
    {
        var spdxDocs = Items.Values.ToList().Where(x => x.Type == "SpdxDocument").ToList();
        if (spdxDocs.Count != 1)
        {
            throw new Spdx3Exception($"Expected exactly one SpdxDocument, but got {spdxDocs.Count}.");
        }

        var result = (SpdxDocument)spdxDocs.First();
        return result;
    }

    /// <summary>
    ///     Reconstruct a model object graph from the flat list of items in the catalog
    /// </summary>
    /// <returns>The SpdxDocument that is the top-level element in the document</returns>
    /// <exception cref="Spdx3SerializationException">If there is not exactly one SpdxDocument element in the catalog</exception>
    public SpdxDocument GetModel()
    {
        ReplacePlaceHoldersWithRealObjects();
        return AssembleSpdxDocument();
    }

    private string GetShortUid()
    {
        // add 13 each time so the numbers look more different from each other and don't look like an incrementing counter
        return (_idCounter += 13).ToString("x");
    }


    /// <summary>
    ///     Take all the rehydrated items in the catalog, and assemble them into an SpdxDocument object
    /// </summary>
    /// <returns>The assembled SpdxDocument from the catalog</returns>
    private SpdxDocument AssembleSpdxDocument()
    {
        var result = GetSpdxDocument();
        foreach (var baseModelClass in Items.Values.ToList())
        {
            if (baseModelClass is Element e)
            {
                result.Element.Add(e);
            }
        }

        return result;
    }

    /// <summary>
    ///     Replace all the placeholders in the Catalog items with references to real objects
    /// </summary>
    private void ReplacePlaceHoldersWithRealObjects()
    {
        foreach (var item in Items.Values.ToList())
        {
            // Get the properties that are Spdx Model Class types and are not null
            var props = item.GetType().GetProperties()
                .Where(p => p.GetValue(item) != null && p.GetValue(item) is BaseModelClass);
            foreach (var prop in props)
            {
                RehydratePlaceHolderWithRealItem(prop, item);
            }
        }
    }

    /// <summary>
    ///     Rehydrate a specific property (which has a placeholder value) on an object with the real object from the catalog
    /// </summary>
    /// <param name="prop">The property that currently has a placeholder that needs replacing</param>
    /// <param name="itemWithProperty">The item that has the placeholder property</param>
    /// <exception cref="Spdx3Exception">If </exception>
    private void RehydratePlaceHolderWithRealItem(PropertyInfo prop, BaseModelClass itemWithProperty)
    {
        var isSpdxClass = prop.PropertyType.IsAssignableTo(typeof(BaseModelClass));
        if (!isSpdxClass)
        {
            return;
        }

        var placeHolder = prop.GetValue(itemWithProperty) as BaseModelClass;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        if (!Items.TryGetValue(placeHolder.SpdxId, out var value))
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        {
            throw new Spdx3Exception($"Could not find catalog item with ID {placeHolder.SpdxId}");
        }

        prop.SetValue(itemWithProperty, value);
    }
}