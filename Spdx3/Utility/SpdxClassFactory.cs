using System.Reflection;
using Spdx3.Exceptions;
using Spdx3.Model;
using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.NonElements;

namespace Spdx3.Utility;

public class SpdxClassFactory
{
    /// <summary>
    /// Default no-arg constructor.
    /// </summary>
    public SpdxClassFactory()
    {
    }

    /// <summary>
    /// Constructor that takes a creation date
    /// </summary>
    /// <param name="creationDate">The date to stomp on everything this factory creates</param>
    public SpdxClassFactory(DateTimeOffset creationDate)
    {
        CreationDate = creationDate;
    }

    private SpdxIdFactory IdFactory { get; set; } = new();
    
    public DateTimeOffset CreationDate { get; set; } = DateTimeOffset.Now;
    
    public List<ISpdxClass> EverythingProduced { get; } = new List<ISpdxClass>();


    public T New<T>() where T : BaseSpdxClass
    {
        var classType = typeof(T);
        if (classType.IsAbstract)
        {
            throw new Spdx3Exception("The classType value of '" + classType.Name + "' is abstract and cannot be instantiated");
        }
        
        var c = Activator.CreateInstance(classType);
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
            info.Created = this.CreationDate;
        }
        
        EverythingProduced.Add(result);
        return result;
    }

}