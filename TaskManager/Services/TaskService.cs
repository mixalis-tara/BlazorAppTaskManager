using Microsoft.EntityFrameworkCore;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Services
{
    public class TaskService : ITaskService
    {
        private readonly ApplicationDbContext _context;
        public TaskService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TodoTask> CreateTaskAsync(TodoTask task)
        {
            try
            {
                task.CreatedAt = DateTime.Now;
                task.LastUpdatedAt = DateTime.Now;

                _context.Tasks.Add(task);
                await _context.SaveChangesAsync();
                return task;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating task: {ex.Message}");
                throw new ApplicationException("An error occurred while creating the task.", ex);
            }

        }

        public async Task DeleteTaskAsync(int id)
        {
            try
            {
                var task = await _context.Tasks.FindAsync(id);
                if (task != null)
                {
                    _context.Tasks.Remove(task);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    throw new KeyNotFoundException($"Task with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting task: {ex.Message}");
                throw new ApplicationException("An error occurred while deleting the task.", ex);
            }
        }

        public async Task<List<TodoTask>> GetAllTasksAsync()
        {
            try
            {
                return await _context.Tasks
                    .OrderByDescending(t => t.CreatedAt)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching tasks: {ex.Message}");
                throw new ApplicationException("An error occurred while fetching tasks.", ex);
            }
        }

        public async Task<TodoTask?> GetTaskByIdAsync(int id)
        {
            try
            {
                return await _context.Tasks.FindAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching task by ID: {ex.Message}");
                throw new ApplicationException("An error occurred while fetching the task.", ex);
            }
        }

        public async Task UpdateTaskAsync(TodoTask task)
        {
            try
            {
                task.LastUpdatedAt = DateTime.Now;
                _context.Tasks.Update(task);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating task: {ex.Message}");
                throw new ApplicationException("An error occurred while updating the task.", ex);
            }
        }
    }
}
