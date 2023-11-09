using ZooManagement.Consts;

namespace ZooManagement.Exceptions;

public class EmployeeNotFoundException:Exception
{
    public EmployeeNotFoundException(int id) : base(Messages.EmployeeNotFoundExceptionMessage(id))
    {
        
    }
}