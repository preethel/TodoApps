using System.Net.Http.Json;
using TodoApps.Shared;

namespace TodoApps.Client.Services.TodoServices
{
    public class TodoService : ITodoService
    {
        private readonly HttpClient _http;
        public TodoService(HttpClient http)
        {
            _http = http;
        }
        public List<Todo> todos { get; set; } = new List<Todo>();
        public HttpClient Http { get; }

        public Task<Todo> GetTodo(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetTodos()
        {
            var result = await _http.GetFromJsonAsync<List<Todo>>("api/todo");
            if(result == null)
            {
                
            }
        }
        
    }
}
