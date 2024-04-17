using Microsoft.AspNetCore.Mvc;
using Practica_ToDoList.Services.Interfaces;

namespace Practica_ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly ITodoItemService _todoItemService;

        public TodoItemController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        // Define los métodos HTTP para manejar las solicitudes relacionadas con las tareas
    }
}
