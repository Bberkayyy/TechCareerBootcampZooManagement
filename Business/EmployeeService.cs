using ZooManagement.Data;
using ZooManagement.Exceptions;
using ZooManagement.Models;

namespace ZooManagement.Business;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public void GetList()
    {
        List<Employee> employees = _employeeRepository.GetAll();
        employees.ForEach(e => Console.WriteLine(e));
    }

    public void Add(Employee employee)
    {
        try
        {
            AddRules(employee);
            _employeeRepository.Add(employee);
            Console.WriteLine($"{employee.Name} isimli bakıcı başarıyla eklendi\n");
            GetList();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _employeeRepository.Delete(id);
            Console.WriteLine($"{id}. sıradaki bakıcı başarıyla silindi.\n");
            GetList();
        }
        catch (EmployeeNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void GetById(int id)
    {
        try
        {
            Employee? employee = _employeeRepository.GetById(id);
            Console.WriteLine(employee);
        }
        catch (EmployeeNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private void AddRules(Employee employee)
    {
        if (employee.Name.Length <= 2)
        {
            throw new NameException(employee.Name);
        }

        if (employee.Age < 18)
        {
            throw new AgeException(employee.Age);
        }

        if (employee.PhoneNumber.Length != 10)
        {
            throw new PhoneNumberException(employee.PhoneNumber);
        }
    }
}