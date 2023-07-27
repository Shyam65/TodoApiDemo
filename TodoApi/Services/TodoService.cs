using TodoApp.Models;

namespace TodoApi.Services
{
    public class TodoService
    {
        private readonly List<TodoTask> _tasks;
        private static int _counter = 0;

        public TodoService()
        {
            _tasks = new List<TodoTask>
            {
                new TodoTask()
                {
                    Id = GetNewTaskId(),
                    Name = "Make specification document.",
                    Priority = TaskPriority.High,
                    Status = TodoApp.Models.TaskStatus.NotStarted
                }
            };
        }

        public List<TodoTask> GetAllTasks()
        {
            return _tasks;
        }

        public TodoTask GetTask(int id)
        {
            return _tasks.Find(t => t.Id == id);
        }

        public void AddTask(TodoTask task)
        {
            task.Id = GetNewTaskId();
            _tasks.Add(task);
        }

        public void UpdateTask(TodoTask task)
        {
            TodoTask existingTask = _tasks.Find(t => t.Id == task.Id);
            existingTask.Name = task.Name;
            existingTask.Priority = task.Priority;
            existingTask.Status = task.Status;
        }

        public void DeleteTask(int id)
        {
            _tasks.Remove(GetTask(id));
        }

        private int GetNewTaskId()
        {
            return ++_counter;
        }
    }
}
