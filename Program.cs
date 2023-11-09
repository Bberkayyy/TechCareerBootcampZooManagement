// See https://aka.ms/new-console-template for more information

using ZooManagement.Business;
using ZooManagement.Data;

// Console.WriteLine("Hello, World!");

IAnimalService animalService = new AnimalService(new AnimalRepository());
IEmployeeService employeeService = new EmployeeService(new EmployeeRepository());
IAnimalTypeService animalTypeService = new AnimalTypeService(new AnimalTypeRepository());

animalService.GetList();
Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-");
employeeService.GetList();
Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-");
animalTypeService.GetList();
