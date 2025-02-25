using Spdx3.Exceptions;
using Spdx3.Model;
using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;
using Spdx3.Tests.Model.Core.Elements;

namespace Spdx3.Utility;

public class SpdxClassFactory
{
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
    public SpdxClassFactory(DateTimeOffset creationDate)
    {
        CreationDate = creationDate;
    }

    private SpdxIdFactory IdFactory { get; } = new();

    public DateTimeOffset CreationDate { get; set; } = DateTimeOffset.Now;

    public List<BaseSpdxClass> EverythingProduced { get; } = new();

    public T New<T>(CreationInfo creationInfo, RelationshipType relationshipType, Element from, List<Element> to)
        where T : Relationship
    {
        var result = NewItem<T>();
        result.CreationInfoSpdxId = creationInfo.SpdxId;
        result.RelationshipType = relationshipType;
        result.FromRef = from.SpdxId;
        to.ForEach(t => result.ToRef.Add(t.SpdxId));
        return result;
    }


    public T New<T>(CreationInfo creationInfo, AnnotationType annotationType, Element subject) where T : Annotation
    {
        var result = NewItem<T>();
        result.CreationInfoSpdxId = creationInfo.SpdxId;
        result.AnnotationType = annotationType;
        result.SubjectRef = subject.SpdxId;
        return result;
    }

    public T New<T>(CreationInfo creationInfo) where T : Element
    {
        var classType = typeof(T);
        // If the caller wants an Annotation, they need to use the other method
        if (classType == typeof(Annotation) || classType.IsSubclassOf(typeof(Annotation)))
            throw new Spdx3Exception($"Parameters of type {nameof(CreationInfo)}, " +
                                     $"{nameof(AnnotationType)}, and {nameof(Element)} are required " +
                                     $"when creating instances of {nameof(Annotation)} or its subclasses");
        // If the caller wants an Relationship, they need to use the other method
        if (classType == typeof(Relationship) || classType.IsSubclassOf(typeof(Relationship)))
            throw new Spdx3Exception($"Parameters of type {nameof(CreationInfo)}, {nameof(RelationshipType)}, " +
                                     $"{nameof(Element)}, and List<{nameof(Element)}> are required " +
                                     $"when creating instances of {nameof(Relationship)} or its subclasses");

        var result = NewItem<T>();
        result.CreationInfoSpdxId = creationInfo.SpdxId;
        return result;
    }

    public T New<T>() where T : BaseSpdxClass
    {
        var classType = typeof(T);
        if (classType == typeof(Element) || classType.IsSubclassOf(typeof(Element)))
            throw new Spdx3Exception(
                $"Parameter of type {nameof(CreationInfo)} required when creating subclasses of {nameof(Element)}");
        return NewItem<T>();
    }

    private T NewItem<T>() where T : BaseSpdxClass
    {
        var classType = typeof(T);
        if (classType.IsAbstract)
            throw new Spdx3Exception("The classType value of '" + classType.Name +
                                     "' is abstract and cannot be instantiated");

        var c = Activator.CreateInstance(classType);
        if (c == null) throw new Spdx3Exception($"An instance of of '{classType.Name}' could not be created");

        var result = (T)Convert.ChangeType(c, classType);
        result.Type = classType.Name;
        result.SpdxId = IdFactory.New(result.Type);
        result.CreatedByFactory = this;

        /*
         * Special handling for CreationInfo classes, which requires the Created property to be set, which should
         * generally come from this factory class and not be left to the user to have to remember to set.
         */
        if (result is CreationInfo info) info.Created = CreationDate;

        EverythingProduced.Add(result);
        return result;
    }
}