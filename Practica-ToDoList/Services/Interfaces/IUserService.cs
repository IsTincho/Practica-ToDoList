using Practica_ToDoList.Data.Entities;

namespace Practica_ToDoList.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> CreateUserAsync(User user);
    }
}
