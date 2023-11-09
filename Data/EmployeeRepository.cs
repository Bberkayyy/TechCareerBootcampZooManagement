using ZooManagement.Exceptions;
using ZooManagement.Models;

namespace ZooManagement.Data;

public class EmployeeRepository:IEmployeeRepository
{
    private readonly List<Employee> _employeeData;
    public EmployeeRepository()
    {
        _employeeData = new List<Employee>()
        {
            new Employee {Id = 1,Age = 25,Name = "Berkay",PhoneNumber = "5999999999"},
            new Employee{Id = 2,Age = 30,Name = "Ceylan",PhoneNumber = "5999999999"},
            new Employee{Id = 3,Age = 42,Name = "Ahmet",PhoneNumber = "5999999999"}
        };
    }
    public void Add(Employee employee)
    {
        _employeeData.Add(employee);
    }

    public void Delete(int id)
    {
        var employee = _employeeData.Where(x => x.Id == id).SingleOrDefault();
        if (employee is null)
        {
            throw new EmployeeNotFoundException(id);
        }

        _employeeData.Remove(employee);
    }

    public List<Employee> GetAll()
    {
        return _employeeData;
    }

    public Employee? GetById(int id)
    {
        Employee employee = _employeeData.Where(x => x.Id == id).SingleOrDefault();
        if (employee == null)
        {
            throw new EmployeeNotFoundException(id);
        }

        return employee;
    }
}