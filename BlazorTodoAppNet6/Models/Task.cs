// Models/Task.cs
namespace BlazorTodoAppNet6.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string? Description { get; set; }

        public bool IsComplete { get; set; }
    }
}
