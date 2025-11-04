namespace ToDoList.Persistence.Repositories;

using System.Collections.Generic;

public interface IRepository<T>
    where T : class
{
    public void Create(T item);
    bool DeleteById(int id);
    List<T> GetAll();
    T ReadById(int id);
    void UpdateById(T item);
}
