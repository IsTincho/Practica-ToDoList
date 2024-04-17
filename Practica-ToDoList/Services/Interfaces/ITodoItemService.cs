using Practica_ToDoList.Data.Entities;

namespace Practica_ToDoList.Services.Interfaces
{
    public interface ITodoItemService
    {
        Task<TodoItem> CreateTodoItemAsync(int userId, TodoItem todoItem);
    }
}
