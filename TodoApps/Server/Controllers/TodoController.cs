using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApps.Server.Services.TodoServices;

namespace TodoApps.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Todo>>>> GetTodos()
        {
            var response = await _todoService.GetTodos();
            return Ok(response);
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Todo>>>> AddTodos(List<Todo> todo)
        {
            try
            {
                if(todo == null)
                {
                    return NotFound();
                }
                var result = await _todoService.AddTodos(todo);
                return Ok(result);

            }
            catch(Exception) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error retrieving data from the database");
            }
        }
    }
}
