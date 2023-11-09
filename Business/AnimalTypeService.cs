using System.Threading.Channels;
using ZooManagement.Data;
using ZooManagement.Exceptions;
using ZooManagement.Models;

namespace ZooManagement.Business;

public class AnimalTypeService : IAnimalTypeService
{
    private readonly IAnimalTypeRepository _animalTypeRepository;

    public AnimalTypeService(IAnimalTypeRepository animalTypes)
    {
        _animalTypeRepository = animalTypes;
    }

    public void GetList()
    {
        List<AnimalType> animalTypes = _animalTypeRepository.GetAll();
        animalTypes.ForEach(x=>Console.WriteLine(x));
    }

    public void Add(AnimalType animalType)
    {
        try
        {
            AddRules(animalType);
            _animalTypeRepository.Add(animalType);
            GetList();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Delete(string id)
    {
        try
        {
            _animalTypeRepository.Delete(id);
            Console.WriteLine($"'{id}' başarıyla silindi.\n");
            GetList();
        }
        catch (AnimalTypeNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void GetById(string id)
    {
        try
        {
            AnimalType? animalType = _animalTypeRepository.GetById(id);
            Console.WriteLine(animalType);
        }
        catch (AnimalTypeNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private void AddRules(AnimalType animalType)
    {
        if (animalType.Name.Length < 3)
        {
            throw new NameException(animalType.Name);
        }
    }
}