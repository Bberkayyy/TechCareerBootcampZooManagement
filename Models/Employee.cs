namespace ZooManagement.Models;

public class Employee : EntityBase<int>
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Id : {Id},\nİsim : {Name},\nTelefon No : {PhoneNumber},\nYaşı : {Age}\n";
    }
}