using ZooManagement.Exceptions;
using ZooManagement.Models;

namespace ZooManagement.Data;

public class AnimalRepository : IAnimalRepository
{
    private readonly List<Animal> _animalData;

    public AnimalRepository()
    {
        _animalData = new List<Animal>()
        {
            new Animal
            {
                Id = 1, AnimalTypeId = "A", EmployeeId = 1,
                Name = "Aslan",
                Description = "Panthera cinsindeki büyük kedilerden biridir ve kedigiller ailesinin bir üyesidir.",
                Quantity = 10
            },
            new Animal
            {
                Id = 2, AnimalTypeId = "A", EmployeeId = 1,
                Name = "Kaplan",
                Description = "Panthera cinsinin en büyük kedisidir. Turuncu-kahverengi renge sahip kürkünün üzerindeki, koyu dikey çizgileri ile kolayca tanınabilir.",
                Quantity = 7
            },
            new Animal
            {
                Id = 3, AnimalTypeId = "A", EmployeeId = 1,
                Name = "Jaguar",
                Description = "Panthera cinsinin dört büyük kedisinden biri olan bir Yeni Dünya memelisidir. ",
                Quantity = 4
            },
            new Animal
            {
                Id = 4, AnimalTypeId = "B", EmployeeId = 2,
                Name = "Zebra",
                Description = "Afrika'da bulunan ve atgiller familyasında sınıflandırılan gövdelerinin tamamını kaplayan ayırt edici siyah ve beyaz çizgilere sahip birkaç canlı türünün ortak adıdır.",
                Quantity = 23
            },
            new Animal
            {
                Id = 5, AnimalTypeId = "B", EmployeeId = 2,
                Name = "Zürafa",
                Description = "Soyu tükenmemiş canlılar arasında karada yaşayan en uzun ve gevişgetirenler arasında da en büyük; Afrika’da yaşayan çift toynaklı memelidir.",
                Quantity = 6
            },
        };
    }

    public void Add(Animal animal)
    {
        _animalData.Add(animal); 
    }

    public void Delete(int id)
    {
        Animal? animal = _animalData.Where(x => x.Id == id).SingleOrDefault();
        if (animal is null)
        {
            throw new AnimalNotFoundException(id);
        }

        _animalData.Remove(animal);
    }

    public List<Animal> GetAll()
    {
        return _animalData;
    }

    public Animal? GetById(int id)
    {
        Animal animal = _animalData.Where(x => x.Id == id).SingleOrDefault();
        if (animal is null)
        {
            throw new AnimalNotFoundException(id);
        }

        return animal;
    }
}