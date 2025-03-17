using Spdx3.Model;

namespace Spdx3.Utility;

/// <summary>
/// The no-argument default constructors for the model classes are protected and internal.
/// In unusual circumstances, it may be necessary to create instances of the model classes without
/// all the protections for mandatory fields that the public constructors offer. This class and
/// the create method provide a way to circumvent all that (at your own peril!)
/// </summary>
public class IncompleteObjectFactory
{
    public static T Create<T>() where T : BaseModelClass
    {
        return Activator.CreateInstance(typeof(T), true) as T ?? throw new InvalidOperationException();
    }
}