using TaskManager.Models;

namespace TaskManager.Services
{
    public interface ITaskService
    {
        Task<List<TodoTask>> GetAllTasksAsync();
        Task<TodoTask?> GetTaskByIdAsync(int id);
        Task<TodoTask> CreateTaskAsync(TodoTask task);
        Task UpdateTaskAsync(TodoTask task);
        Task DeleteTaskAsync(int id);
    }
}
