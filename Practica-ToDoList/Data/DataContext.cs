using Microsoft.EntityFrameworkCore;
using Practica_ToDoList.Data.Entities;

namespace Practica_ToDoList.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }

        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions) { }

    }
}
