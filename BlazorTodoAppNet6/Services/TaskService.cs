// Services/TaskService.cs
using BlazorTodoAppNet6.Models;
using System.Collections.Generic;
using TaskModel = BlazorTodoAppNet6.Models.Task;

namespace BlazorTodoAppNet6.Services
{
    public class TaskService
    {
        private List<TaskModel> _tasks = new List<TaskModel>();

        public List<TaskModel> GetAllTasks() => _tasks;

        public void AddTask(TaskModel task)
        {
            task.Id = _tasks.Any() ? _tasks.Max(t => t.Id) + 1 : 1;
            _tasks.Add(task);
        }


        public void DeleteTask(int id) => _tasks.RemoveAll(t => t.Id == id);

        public void ToggleComplete(int id)
        {
            var task = _tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.IsComplete = !task.IsComplete;
            }
        }
    }
}
