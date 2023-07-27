namespace TodoApp.Models
{
    public class AddTaskRequest
    {
        public string Name { get; set; }

        public int Priority { get; set; }

        public TaskStatus Status { get; set; }
    }
}
