using Spdx3.Model;

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
}