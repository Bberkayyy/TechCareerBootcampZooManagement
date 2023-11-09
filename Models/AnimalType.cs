namespace ZooManagement.Models;

public class AnimalType:EntityBase<string>
{
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Id : {Id},\nİsim : {Name}";
    }
}