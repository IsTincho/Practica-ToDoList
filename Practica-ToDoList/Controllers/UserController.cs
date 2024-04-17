using Microsoft.AspNetCore.Mvc;
using Practica_ToDoList.Services.Interfaces;

namespace Practica_ToDoList.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // Define los métodos HTTP para manejar las solicitudes relacionadas con los usuarios
    }

}
