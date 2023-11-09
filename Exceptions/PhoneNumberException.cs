using ZooManagement.Consts;

namespace ZooManagement.Exceptions;

public class PhoneNumberException:Exception
{
    public PhoneNumberException(string number):base(Messages.PhoneNumberExceptionMessage(number))
    {
        
    }
}