namespace ZooManagement.Data;

public interface IEntityBaseRepository<TypeOfEntity,TypeOfId>
{
    void Add(TypeOfEntity TypeOfEntity);

    void Delete(TypeOfId id);

    List<TypeOfEntity> GetAll();

    TypeOfEntity? GetById(TypeOfId id);
}