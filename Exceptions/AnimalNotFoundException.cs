using ZooManagement.Consts;

namespace ZooManagement.Exceptions;

public class AnimalNotFoundException : Exception
{
    public AnimalNotFoundException(int id) : base(Messages.AnimalNotFoundExceptionMessage(id))
    {
        
    }
}