namespace Spdx3.Utility;

/// <summary>
/// Factory that generates an SPDX ID, which is a URN that uniquely identifies an SPDX element within the context of an SPDX document.  
/// 
/// There's no semantic meaning, and no real correspondence to real life objects.  
/// It's just an element identifier used within the document, so things can reference each other.
///
/// Remember: Unique ID generation means you need to be concerned about threading and concurrency.
/// 
/// The default implelemntation is SpdxFactory, and should work if you don't need predictability/reproducability of ID generation in 
/// multi-threaded scenarios.  
/// 
/// There's also test implementations in the testing project.
/// </summary>
public interface ISpdxIdFactory
{
    string New(string type);
}