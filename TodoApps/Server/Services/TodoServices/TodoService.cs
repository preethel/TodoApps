using Microsoft.EntityFrameworkCore;
using TodoApps.Server.Data;

namespace TodoApps.Server.Services.TodoServices
{
    public class TodoService : ITodoService
    {
        private DataContext _context;
        public TodoService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Todo>>> GetTodos()
        {
            var todos = await _context.Todos.ToListAsync();
            var response = new ServiceResponse<List<Todo>>
            {
                Data = todos
            };
            return response;

        }
        public async Task<ServiceResponse<List<Todo>>> AddTodos(List<Todo> todo)
        {
            var result = new ServiceResponse<List<Todo>>
            {
                Data = new List<Todo>()
            };
            foreach (var item in todo)
            {
                result.Data.Add(item);
            }
            _context.SaveChanges();
            return result;
        }
    }
}
