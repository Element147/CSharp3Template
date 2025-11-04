using ToDoList.Domain.Models;

namespace ToDoList.Persistence.Repositories;

public class ToDoItemsRepository : IRepository<ToDoItem>
{

    private readonly ToDoItemsContext context;
    public ToDoItemsRepository(ToDoItemsContext context)
    {
        this.context = context;
    }
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

    public List<ToDoItem> GetAll()
    {
        return context.ToDoItems.ToList();
    }

    public ToDoItem ReadById(int toDoItemId)
    {
        return context.ToDoItems.Find(toDoItemId);
    }

    public void UpdateById(ToDoItem itemToUpdate)
    {
        context.ToDoItems.Update(itemToUpdate);
        context.SaveChanges();
    }
}
