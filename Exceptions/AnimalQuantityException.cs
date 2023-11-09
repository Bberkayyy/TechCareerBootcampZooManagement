using ZooManagement.Consts;

namespace ZooManagement.Exceptions;

public class AnimalQuantityException : Exception
{
    public AnimalQuantityException(int quantity) : base(Messages.AnimalQuantityExceptionMessage(quantity))
    {
    }
}