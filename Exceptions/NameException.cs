using ZooManagement.Consts;

namespace ZooManagement.Exceptions;

public class NameException:Exception
{
    public NameException(string name) : base(Messages.NameExceptionMessage(name))
    {
        
    }
}