using ZooManagement.Consts;

namespace ZooManagement.Exceptions;

public class AgeException:Exception
{
    public AgeException(int age):base(Messages.AgeExceptionMessage(age))
    {
        
    }
}