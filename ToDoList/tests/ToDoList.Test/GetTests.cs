using System;

namespace ToDoList.Test;

using ToDoList.Domain.DTOs;
using ToDoList.Domain.Models;
using ToDoList.WebApi;
public class GetTests
{

    [Fact]
    public void Get_ALLItems_ReturnAllItems()
    {
        // Arrange
        var todoItem = new ToDoItem
        {
            ToDoItemId = 1,
            Name = "Test Item",
            Description = "This is a test item",
            IsCompleted = false
        };
        var todoItem2 = new ToDoItem
        {
            ToDoItemId = 1,
            Name = "Test Item",
            Description = "This is a test item",
            IsCompleted = false
        };


        var controller = new ToDoItemsController();
        controller.AddItemToStorage(todoItem);
        controller.AddItemToStorage(todoItem2);

        // Act
        var result = controller.Read();

        // Assert
        Assert.NotNull(result);

        // Extract the value from the ActionResult
        var okResult = Assert.IsType<Microsoft.AspNetCore.Mvc.OkObjectResult>(result.Result);
        var items = Assert.IsAssignableFrom<IEnumerable<ToDoItemGetResponseDto>>(okResult.Value);
        Assert.Equal(2, items.Count());
        var first = items.ToList().First();
        Assert.Equal("Test Item", first.Name);
    }
}
