using TodoApps.Shared;

namespace TodoApps.Client.Services.TodoServices
{
    public interface ITodoService
    {
        List<Todo> todos { get; set; }
        Task GetTodos();
        Task<Todo> GetTodo(int id);
    }
}
