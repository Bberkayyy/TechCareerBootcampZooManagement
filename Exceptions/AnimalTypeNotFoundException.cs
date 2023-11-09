using ZooManagement.Consts;

namespace ZooManagement.Exceptions;

public class AnimalTypeNotFoundException : Exception
{
    public AnimalTypeNotFoundException(string id) : base(Messages.AnimalTypeNotFoundExceptionMessage(id))
    {
        
    }
}