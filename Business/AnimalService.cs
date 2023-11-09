using ZooManagement.Data;
using ZooManagement.Exceptions;
using ZooManagement.Models;

namespace ZooManagement.Business;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;

    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }

    public void GetList()
    {
        List<Animal> animals = _animalRepository.GetAll();
        animals.ForEach(animal => Console.WriteLine(animal));
    }

    public void Add(Animal animal)
    {
        try
        {
            AddRules(animal);
            _animalRepository.Add(animal);
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
            _animalRepository.Delete(id);
            Console.WriteLine($"{id} Başarıyla silidi\n");
            GetList();
        }
        catch (AnimalNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void GetById(int id)
    {
        try
        {
            Animal? animal = _animalRepository.GetById(id);
            Console.WriteLine(animal);
        }
        catch (AnimalNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private void AddRules(Animal animal)
    {
        if (animal.Name.Length <= 2)
        {
            throw new NameException(animal.Name);
        }

        if (animal.Quantity < 1)
        {
            throw new AnimalQuantityException(animal.Quantity);
        }
    }
}