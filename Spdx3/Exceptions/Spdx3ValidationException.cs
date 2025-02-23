using Spdx3.Model;

namespace Spdx3.Exceptions;

public class Spdx3ValidationException(ISpdxClass obj, string propertyName, string why)
    : Spdx3Exception($"Object {obj.GetType().Name}, property {propertyName}: {why}");