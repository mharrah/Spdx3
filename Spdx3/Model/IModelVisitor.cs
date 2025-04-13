namespace Spdx3.Model;

public interface IModelVisitor
{
    void Visit(IModelClass element);
}