namespace Spdx3.Utility;

/// <summary>
///     Factory that generates an SPDX ID, which is a URN that uniquely identifies an SPDX element within the context of an
///     SPDX document.
///     There's no semantic meaning, and no real correspondence to real life objects.
///     It's just an element identifier used within the document, so things can reference each other.
/// </summary>
public sealed class SpdxIdFactory : ISpdxIdFactory
{
    private int
        _idCounter =
            1000; // start at 1000 so the generated numbers are more than 3 digits long and will look like hex numbers when rendered

    public string New(string type)
    {
        return $"urn:{type}:{GetShortUid()}";
    }

    private string GetShortUid()
    {
        // add 13 each time so the numbers look more different from each other and don't look like an incrementing counter
        return (_idCounter += 13).ToString("x");
    }
}