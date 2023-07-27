namespace TodoApp.Models
{
    public class TodoTask
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public TaskPriority Priority { get; set; }

        public TaskStatus Status { get; set; }

    }
}
