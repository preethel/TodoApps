namespace TodoApps.Server.Services.TodoServices
{
    public interface ITodoService
    {
        Task<ServiceResponse<List<Todo>>> GetTodos();
        Task<ServiceResponse<List<Todo>>> AddTodos(List<Todo> todo);
    }
}
