using Practica_ToDoList.Data;
using Practica_ToDoList.Data.Entities;
using Practica_ToDoList.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Practica_ToDoList.Services.Implementations
{
    public class TodoItemService : ITodoItemService
    {
        private readonly DataContext _context;

        public TodoItemService(DataContext context)
        {
            _context = context;
        }

        public async Task<TodoItem> CreateTodoItemAsync(int userId, TodoItem todoItem)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null)
            {
                throw new ArgumentException("User not found");
            }

            todoItem.UserId = userId;
            _context.TodoItems.Add(todoItem);
            await _context.SaveChangesAsync();

            return todoItem;
        }
    }
}
