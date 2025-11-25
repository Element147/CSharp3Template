namespace ToDoList.Frontend.Clients;

using ToDoList.Domain.DTOs;
using ToDoList.Frontend.Models;

public class ToDoItemsClient : IToDoItemsClient
{
    private readonly HttpClient httpClient;
    public ToDoItemsClient(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public List<ToDoItemView> ReadItems()
    {
        var toDoItemsViews = new List<ToDoItemView>();
        var response = httpClient.GetFromJsonAsync<List<ToDoItemGetResponseDto>>("api/ToDoItems");

        toDoItemsViews = response.Result.Select(dto => new ToDoItemView(dto.Id, dto.Name, dto.Description, dto.IsCompleted)).ToList();
        return toDoItemsViews;
    }
}
