namespace ZooManagement.Business;

public interface IBaseService<TypeOfEntity,TypeOfId>
{
    void GetList();
    void Add(TypeOfEntity typeOfEntity);
    void Delete(TypeOfId id);
    void GetById(TypeOfId id);
    
}