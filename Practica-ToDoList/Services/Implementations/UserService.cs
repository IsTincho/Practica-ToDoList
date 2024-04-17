using Practica_ToDoList.Data;
using Practica_ToDoList.Data.Entities;
using Practica_ToDoList.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Practica_ToDoList.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
