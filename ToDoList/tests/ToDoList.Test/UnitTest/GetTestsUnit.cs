using System;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using ToDoList.Domain.DTOs;
using ToDoList.Domain.Models;
using ToDoList.Persistence.Repositories;
using ToDoList.WebApi.Controllers;

namespace ToDoList.Test.UnitTest;

public class GetTestsUnit
{

    [Fact]
    public void Get_ReadWhenSomeItemAvailable_ReturnsOK()
    {
        // Arrange
        var repositoryMock = Substitute.For<IRepository<ToDoItem>>();
        var conttroller = new ToDoItemsController(repositoryMock);

        var toDoItem = new ToDoItem
        {
            Name = "Jmeno",
            Description = "Popis",
            IsCompleted = false
        };
        repositoryMock.GetAll().Returns([toDoItem]);

        // Act
        var result = conttroller.Read();

        // Assert
        Assert.IsType<ActionResult<IEnumerable<ToDoItemGetResponseDto>>>(result);
        repositoryMock.Received(1).GetAll();
    }
}
