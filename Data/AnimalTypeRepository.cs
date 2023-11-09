using ZooManagement.Exceptions;
using ZooManagement.Models;

namespace ZooManagement.Data;

public class AnimalTypeRepository : IAnimalTypeRepository
{
    private readonly List<AnimalType> _animalTypeData;

    public AnimalTypeRepository()
    {
        _animalTypeData = new List<AnimalType>()
        {
            new AnimalType { Id = "A", Name = "Panthera" },
            new AnimalType { Id = "B", Name = "Atgiller" }
        };
    }

    public void Add(AnimalType animalType)
    {
        _animalTypeData.Add(animalType);
    }

    public void Delete(string id)
    {
        AnimalType? animalType = _animalTypeData.Where(x => x.Id == id).SingleOrDefault();
        if (animalType == null)
        {
            throw new AnimalTypeNotFoundException(id);
        }

        _animalTypeData.Remove(animalType);
    }

    public List<AnimalType> GetAll()
    {
        return _animalTypeData;
    }

    public AnimalType? GetById(string id)
    {
        AnimalType animalType = _animalTypeData.Where(a => a.Id == id).SingleOrDefault();
        if (animalType is null)
        {
            throw new AnimalTypeNotFoundException(id);
        }

        return animalType;
    }
}