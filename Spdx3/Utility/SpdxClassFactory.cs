using System.Reflection;
using Spdx3.Exceptions;
using Spdx3.Model;
using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;

namespace Spdx3.Utility;

public class SpdxClassFactory
{
    private static Dictionary<string, string> _prefixesForNamespaces = new()
    {
        { "Model.Core", "" },
        { "Model.Security", "security_" },
        { "Model.Software", "software_" },
        { "Model.Licensing", "licensing_" },
        { "Model.SimpleLicensing", "simplelicensing_" },
        { "Model.ExpandedLicensing", "expandedlicensing_" },
        { "Model.Dataset", "dataset_" },
        { "Model.AI", "ai_" },
        { "Model.Build", "build_" },
        { "Model.Lite", "lite_" },
        { "Model.Extension", "extension_" }
    };

    /// <summary>
    /// This is a map of Types to method signatures.
    /// When requesting a subclass of Key, you should use the method with the signature Value.
    /// </summary>
    private static Dictionary<Type, string> _typeToSignatureMap = new()
    {
        {
            typeof(Annotation),
            "New(CreationInfo creationInfo, AnnotationType annotationType, Element subject)"
        },
        {
            typeof(Relationship),
            "New(CreationInfo creationInfo, RelationshipType relationshipType, Element from, List<Element> to)"
        },
        { typeof(BaseSpdxClass), "New()" },
        { typeof(ExternalRef), "New(ExternalRefType externalRefType)" },
        { typeof(Element), "New(CreationInfo creationInfo)" },
        { typeof(ExternalIdentifier), "New(ExternalIdentifierType externalIdentifierType, string identifier)" }
    };

    /// <summary>
    ///     Default no-arg constructor.
    /// </summary>
    public SpdxClassFactory()
    {
    }

    /// <summary>
    ///     Constructor that takes a creation date
    /// </summary>
    /// <param name="creationDate">The date to stomp on everything this factory creates</param>
    public SpdxClassFactory(DateTimeOffset creationDate) : this()
    {
        CreationDate = creationDate;
    }


    /// <summary>
    /// An ID factory for getting SPDX ID's 
    /// </summary>
    private SpdxIdFactory IdFactory { get; } = new();

    /// <summary>
    ///  The creation date that will be stamped on everything this factory creates
    /// </summary>
    public DateTimeOffset CreationDate { get; set; } = DateTimeOffset.Now;

    /// <summary>
    /// Keeps a copy of everything produced by this factory
    /// </summary>
    public List<BaseSpdxClass> EverythingProduced { get; } = [];

    /// <summary>
    /// Creates a BaseSpdxClass (or a subclass that doesn't take required fields)
    /// </summary>
    /// <typeparam name="T">The type of class you want</typeparam>
    /// <returns>An instance of the desired class, with required fields populated</returns>
    public T New<T>() where T : BaseSpdxClass
    {
        ValidateCallingRightMethod(typeof(T), typeof(BaseSpdxClass));
        return NewRawClass<T>();
    }

    /// <summary>
    /// Creates an ExternalIdentifer (or a subclass of it)
    /// </summary>
    /// <param name="externalIdentifierType">The type of external identifier</param>
    /// <param name="identifier">The identifier value</param>
    /// <typeparam name="T">The type of class you want.  Must be an ExternalIdentfier or a subclass of it.</typeparam>
    /// <returns>An instance of the desired class, with required fields populated</returns>
    public T New<T>(ExternalIdentifierType externalIdentifierType, string identifier) where T : ExternalIdentifier
    {
        ValidateCallingRightMethod(typeof(T), typeof(ExternalIdentifier));
        var result = NewRawClass<T>();
        result.ExternalIdentifierType = externalIdentifierType;
        result.Identifier = identifier;
        return result;
    }

    /// <summary>
    /// Creates an ExternalRef (or a subclass of it)
    /// </summary>
    /// <param name="externalRefType">The type of external reference</param>
    /// <typeparam name="T">The type of class you want.  Must be an ExternalRef or a subclass of it.</typeparam>
    /// <returns>An instance of the desired class, with required fields populated</returns>
    public T New<T>(ExternalRefType externalRefType) where T : ExternalRef
    {
        ValidateCallingRightMethod(typeof(T), typeof(ExternalRef));
        var result = NewRawClass<T>();
        result.ExternalRefType = externalRefType;
        return result;
    }


    /// <summary>
    /// Creates an ExternalMap (or a subclass of it)
    /// </summary>
    /// <param name="externalSpdxId">The ID in the external document</param>
    /// <typeparam name="T">The type of class you want.  Must be an ExternalMap or a subclass of it.</typeparam>
    /// <returns>An instance of the desired class, with required fields populated</returns>
    public T New<T>(string externalSpdxId) where T : ExternalMap
    {
        ValidateCallingRightMethod(typeof(T), typeof(ExternalRef));
        var result = NewRawClass<T>();
        result.ExternalSpdxId = externalSpdxId;
        return result;
    }

    /// <summary>
    /// Creates an Element (or one of its subclasses that only requires a CreationInfo property)
    /// </summary>
    /// <param name="creationInfo">Information about the creation of this entry</param>
    /// <typeparam name="T">The type of class you want.  Must be an Element or a subclass of it.</typeparam>
    /// <returns>An instance of the desired class, with required fields populated</returns>
    public T New<T>(CreationInfo creationInfo) where T : Element
    {
        ValidateCallingRightMethod(typeof(T), typeof(Element));

        var result = NewRawClass<T>();
        result.CreationInfoSpdxId = creationInfo.SpdxId;
        return result;
    }

    /// <summary>
    /// Create an Annotation (or a subclass of it)
    /// </summary>
    /// <param name="creationInfo">Information about the creation of this entry</param>
    /// <param name="annotationType">The type of annotation</param>
    /// <param name="subject">The subject (Element) being annotated.</param>
    /// <typeparam name="T">The type of class you want.  Must be an Annotation or a subclass of it.</typeparam>
    /// <returns>An instance of the desired class, with required fields populated</returns>
    public T New<T>(CreationInfo creationInfo, AnnotationType annotationType, Element subject) where T : Annotation
    {
        ValidateCallingRightMethod(typeof(T), typeof(Annotation));

        var result = NewRawClass<T>();
        result.CreationInfoSpdxId = creationInfo.SpdxId;
        result.AnnotationType = annotationType;
        result.Subject = subject;
        return result;
    }

    /// <summary>
    /// Create a Relationship
    /// </summary>
    /// <param name="creationInfo">Information about the creation of this entry</param>
    /// <param name="relationshipType">The type of relationship this represents</param>
    /// <param name="from">The "from" entity. In the statement 'X is related to Y', this would be the X.</param>
    /// <param name="to">A list of "to" entities. In the statement 'X is related to [Y,Z]', this would be the [Y,Z].</param>
    /// <typeparam name="T">The type of class you want.  Must be a Relationship or a subclass of it.</typeparam>
    /// <returns>An instance of the desired class, with required fields populated</returns>
    public T New<T>(CreationInfo creationInfo, RelationshipType relationshipType, Element from, List<Element> to)
        where T : Relationship
    {
        ValidateCallingRightMethod(typeof(T), typeof(Relationship));

        var result = NewRawClass<T>();
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
    private T NewRawClass<T>() where T : BaseSpdxClass
    {
        var classType = typeof(T);
        var c = Activator.CreateInstance(classType, BindingFlags.Instance | BindingFlags.NonPublic, null, null, null);
        if (c == null)
        {
            throw new Spdx3Exception($"An instance of of '{classType.Name}' could not be created");
        }

        var result = (T)Convert.ChangeType(c, classType);
        result.Type = SpdxTypeForClass(classType);
        result.SpdxId = IdFactory.New(classType.Name);
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

    private static string SpdxTypeForClass(Type classType)
    {
        if (classType?.Namespace == null)
        {
            throw new Spdx3Exception($"Unable to determine SPDX3 node type value for {classType.FullName}");
        }

        foreach (var prefix in _prefixesForNamespaces.Keys.Where(
                     prefix => classType.Namespace.StartsWith($"Spdx3.{prefix}")
                               || classType.Namespace.StartsWith($"Spdx3.Tests.{prefix}")
                 )
                )
        {
            return $"{_prefixesForNamespaces[prefix]}{classType.Name}";
        }

        throw new Spdx3Exception($"Unable to determine SPDX3 node type value for {classType.FullName}");
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
    private static void ValidateCallingRightMethod(Type requestedType, Type requiredType)
    {
        if (requestedType.IsAbstract)
        {
            throw new Spdx3Exception($"The requested type {requestedType.Name} is abstract and cannot be created.");
        }

        // Default to the BaseSpdxClass
        var bestMatchSoFar = new KeyValuePair<Type, string>(typeof(BaseSpdxClass),
            _typeToSignatureMap[typeof(BaseSpdxClass)]);
        
        // Look for a more specific signature that could be used
        foreach (var signature in _typeToSignatureMap
                     .Where(
                         /* it is applicable */ 
                         signature => requestedType == signature.Key || requestedType.IsSubclassOf(signature.Key))
                     .Where(
                         /* and is more specific than the best so far */ 
                         signature => signature.Key.IsSubclassOf(bestMatchSoFar.Key))
                 )
        {
            // this is a better fit
            bestMatchSoFar = signature;
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