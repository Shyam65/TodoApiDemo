namespace TodoApp.Models
{
    public class UpdateTaskRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Priority { get; set; }

        public TaskStatus Status { get; set; }
    }
}
