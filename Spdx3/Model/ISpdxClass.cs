using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model;

public interface ISpdxClass
{
    public string Type { get; internal set; }

    public string SpdxId { get; internal set; }

    /// <summary>Returns the object as a JSON string, with the sort of formatting that's typical/expected for SPDX files.</summary>
    /// <returns>A Json representation of this object</returns>
    public string ToJson();

    /// <summary>
    /// Check if this object is valid (primarily, are the required elements populated).
    /// This is needed because JSON serialization requires default constructors which don't work well
    /// with non-nullable properties, so properties are generally nullable.  This is how we
    /// enforce required elements.
    ///
    /// In subclasses, override this method, and do validations, throwing Spdx3ValidationExceptions for problems
    /// </summary>
    public void Validate();
}