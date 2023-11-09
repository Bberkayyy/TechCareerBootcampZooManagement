namespace ZooManagement.Models;

public abstract class EntityBase<TypeOfId>
{
    public TypeOfId Id { get; set; }
}