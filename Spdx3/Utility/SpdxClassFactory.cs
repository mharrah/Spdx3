using System.Reflection;
using Spdx3.Exceptions;
using Spdx3.Model;
using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.NonElements;

namespace Spdx3.Utility;

public class SpdxClassFactory
{
    private SpdxIdFactory IdFactory { get; set; } = new();
    
    public DateTimeOffset CreationDate { get; set; } = DateTimeOffset.Now;

    public ISpdxClass NewClass(System.Type classType)
    {
        var nameOfInterface = typeof(ISpdxClass).FullName;
        if (null == nameOfInterface)
        {   
            throw new Spdx3Exception($"The Type for interface ISpdxClass could not be determined from reflection");
        }

        var interfaceType = classType.GetInterface(nameOfInterface);
        if (null == interfaceType)
        {
            throw new Spdx3Exception($"The classType value of '{classType.Name}' does not implement ISpdxClass");
        }

        if (classType.IsAbstract)
        {
            throw new Spdx3Exception("The classType value of '" + classType.Name + "' is abstract and cannot be instantiated");
        }
        
        var c = Activator.CreateInstance(classType);
        if (c == null)
        {
            throw new Spdx3Exception($"An instance of of '{classType.Name}' could not be created");
        }

        var result = (BaseSpdxClass)Convert.ChangeType(c, classType);
        result.Type = classType.Name;
        result.SpdxId = IdFactory.New(result.Type);
        result.CreatedByFactory = this;
        
        /*
         * Special handling for CreationInfo classes, which requires the Created property to be set, which should
         * generally come from this factory class and not be left to the user to have to remember to set.
         */
        if (result is CreationInfo info)
        {
            info.Created = this.CreationDate;
        }
        
        return result;
    }

    public Element NewElement(System.Type elementType, CreationInfo creationInfo)
    {
        if (!elementType.IsSubclassOf(typeof(Element)))
        {
            throw new Spdx3Exception($"The type {elementType.Name} is not a subclass of Element");
        }

        if (elementType.IsAbstract)
        {
            throw new Spdx3Exception("The classType value of '" + elementType.Name + "' is abstract and cannot be instantiated");
        }
        
        var c = Activator.CreateInstance(elementType);
        if (c == null)
        {
            throw new Spdx3Exception($"An instance of of '{elementType.Name}' could not be created");
        }

        var result = (Element)Convert.ChangeType(c, elementType);
        result.Type = elementType.Name;
        result.SpdxId = IdFactory.New(result.Type);
        result.CreatedByFactory = this;
        result.CreationInfoSpdxId = creationInfo.SpdxId;
        
        return result;
    }   


}