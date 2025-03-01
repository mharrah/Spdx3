using System.Reflection;
using Spdx3.Exceptions;
using Spdx3.Model;
using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;

namespace Spdx3.Utility;

public class SpdxClassFactory
{
    /// <summary>
    /// This is a map of Types to method signatures.
    /// When requesting a subclass of Key, you should use the method with the signature Value.
    /// </summary>
    private readonly IDictionary<Type, string> _typeToSignatureMap = new Dictionary<Type, string>();

    /// <summary>
    ///     Default no-arg constructor.
    /// </summary>
    public SpdxClassFactory()
    {
        _typeToSignatureMap[typeof(Annotation)] =
            "New(CreationInfo creationInfo, AnnotationType annotationType, Element subject)";
        _typeToSignatureMap[typeof(Relationship)] =
            "New(CreationInfo creationInfo, RelationshipType relationshipType, Element from, List<Element> to)";
        _typeToSignatureMap[typeof(BaseSpdxClass)] = "New()";
        _typeToSignatureMap[typeof(Element)] = "New(CreationInfo creationInfo)";
    }

    /// <summary>
    ///     Constructor that takes a creation date
    /// </summary>
    /// <param name="creationDate">The date to stomp on everything this factory creates</param>
    public SpdxClassFactory(DateTimeOffset creationDate) : this()
    {
        CreationDate = creationDate;
    }

    private SpdxIdFactory IdFactory { get; } = new();

    public DateTimeOffset CreationDate { get; set; } = DateTimeOffset.Now;

    public List<BaseSpdxClass> EverythingProduced { get; } = [];

    public T New<T>() where T : BaseSpdxClass
    {
        ValidateCallingRightMethod(typeof(T), typeof(BaseSpdxClass));
        return NewBaseClass<T>();
    }

    public T New<T>(CreationInfo creationInfo) where T : Element
    {
        ValidateCallingRightMethod(typeof(T), typeof(Element));

        var result = NewBaseClass<T>();
        result.CreationInfoSpdxId = creationInfo.SpdxId;
        return result;
    }

    public T New<T>(CreationInfo creationInfo, AnnotationType annotationType, Element subject) where T : Annotation
    {
        ValidateCallingRightMethod(typeof(T), typeof(Annotation));

        var result = NewBaseClass<T>();
        result.CreationInfoSpdxId = creationInfo.SpdxId;
        result.AnnotationType = annotationType;
        result.Subject = subject;
        return result;
    }

    public T New<T>(CreationInfo creationInfo, RelationshipType relationshipType, Element from, List<Element> to)
        where T : Relationship
    {
        ValidateCallingRightMethod(typeof(T), typeof(Relationship));

        var result = NewBaseClass<T>();
        result.CreationInfoSpdxId = creationInfo.SpdxId;
        result.RelationshipType = relationshipType;
        result.From = from;
        to.ForEach(t => result.To.Add(t));
        return result;
    }


    /// <summary>
    /// This is the underlying private method that all the public methods share, and is the one that actually
    /// instantiates objects for the factory.
    ///
    /// It uses reflection to create an instance of the requested type, sets the Type property and the SpdxID,
    /// and adds a link back to the factory that created the object.
    ///
    /// If the type requested is a subclass of BaseSpdxClass with additional properties, the calling New() method
    /// needs to set those.
    /// </summary>
    /// <typeparam name="T">The type of object that the caller has requested</typeparam>
    /// <returns>A new, and likely incompletely-populated instance of the requested object type </returns>
    /// <exception cref="Spdx3Exception">Something has gone wrong</exception>
    private T NewBaseClass<T>() where T : BaseSpdxClass
    {
        var classType = typeof(T);
        var c = Activator.CreateInstance(classType, BindingFlags.Instance | BindingFlags.NonPublic, null, null, null);
        if (c == null)
        {
            throw new Spdx3Exception($"An instance of of '{classType.Name}' could not be created");
        }

        var result = (T)Convert.ChangeType(c, classType);
        result.Type = classType.Name;
        result.SpdxId = IdFactory.New(result.Type);
        result.CreatedByFactory = this;

        /*
         * Special handling for CreationInfo classes, which requires the Created property to be set, which should
         * generally come from this factory class and not be left to the user to have to remember to set.
         */
        if (result is CreationInfo info)
        {
            info.Created = CreationDate;
        }

        EverythingProduced.Add(result);
        return result;
    }

    /// <summary>
    /// Validate that the caller didn't use the wrong overload of New() for the object type they want.
    ///
    /// The New() method is overloaded to take (as parameters) values for mandatory fields on the objects
    /// they create, using genearics.  For example, all subclasses of Element require a mandatory CreationInfo
    /// field.  If the caller calls the New() method that doesn't take this required field, this method will throw
    /// an exception, with a message for the method signature that they should have used.
    ///
    /// This is just one example, but any class in the model that has required fields for it and its subclasses
    /// should be added to the private Dictionary on the class, in the default constructor.
    /// </summary>
    /// <param name="requestedType">The type of object that was requested</param>
    /// <param name="requiredType">The type of object that the requested type must be for the method signature actually used</param>
    /// <exception cref="Spdx3Exception">If the wrong method signature was used for the requested type</exception>
    private void ValidateCallingRightMethod(Type requestedType, Type requiredType)
    {
        if (requestedType.IsAbstract)
        {
            throw new Spdx3Exception($"The requested type {requestedType.Name} is abstract and cannot be created.");
        }

        // Default to the BaseSpdxClass
        var bestMatchSoFar = new KeyValuePair<Type, string>(typeof(BaseSpdxClass),
            _typeToSignatureMap[typeof(BaseSpdxClass)]);
        // Look for a more specific signature that could be used
        foreach (var signature in _typeToSignatureMap)
        {
            // If this signature CAN be used for the requested type...
            if (requestedType == signature.Key || requestedType.IsSubclassOf(signature.Key))
            {
                // ...and is more specific than the best match so far...
                if (signature.Key.IsSubclassOf(bestMatchSoFar.Key))
                {
                    // this is a better fit
                    bestMatchSoFar = signature;
                }
            }
        }

        // We have the signature that we should be using. Is the requiredType a subclass of the best signature?
        if (requiredType != bestMatchSoFar.Key && !requiredType.IsSubclassOf(bestMatchSoFar.Key))
        {
            // Nope, that's a problem
            throw new Spdx3Exception(
                $"Creating instances of {requestedType.Name} requires using the {bestMatchSoFar.Value} form");
        }
    }
}