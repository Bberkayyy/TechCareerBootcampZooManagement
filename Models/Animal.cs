namespace ZooManagement.Models;

public class Animal : EntityBase<int>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public string AnimalTypeId { get; set; }
    public int EmployeeId { get; set; }

    public override string ToString()
    {
        return
            $"Id : {Id},\nName : {Name},\nAçıklama : {Description},\nMevcut : {Quantity},\nTürü : {AnimalTypeId}\nBakcı Id : {EmployeeId}\n";
    }
}