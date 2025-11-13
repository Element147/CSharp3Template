using ToDoList.Domain.Models;

namespace ToDoList.Persistence.Repositories;

public class ToDoItemsRepository(ToDoItemsContext context) : IRepository<ToDoItem>
{

    private readonly ToDoItemsContext context = context;

    public void Create(ToDoItem item)
    {
        context.ToDoItems.Add(item);
        context.SaveChanges();
    }

    public bool DeleteById(int id)
    {
        var itemToDelete = context.ToDoItems.Find(id);
        if (itemToDelete == null)
        {
            return false;
        }

        context.ToDoItems.Remove(itemToDelete);
        context.SaveChanges();
        return true;
    }

    public List<ToDoItem> GetAll() => context.ToDoItems.ToList();

    public ToDoItem? ReadById(int id) => context.ToDoItems.Find(id);

    public void UpdateById(ToDoItem itemToUpdate)
    {
        context.ToDoItems.Update(itemToUpdate);
        context.SaveChanges();
    }
}
