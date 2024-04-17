namespace Practica_ToDoList.Data.Entities
{
    using System.Collections.Generic;

    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public ICollection<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
    }


}

