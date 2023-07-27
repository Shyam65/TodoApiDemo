using Microsoft.AspNetCore.Mvc;
using TodoApi.Services;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _todoService;

        public TodoController(TodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public List<TodoTask> GetAllTasks()
        {
            return _todoService.GetAllTasks();
        }

        [HttpGet("{id}")]
        public TodoTask GetTask(int id)
        {
            return _todoService.GetTask(id);
        }

        [HttpPost]
        public void AddNewTask(TodoTask newTask)
        {
            _todoService.AddTask(newTask);
        }

        [HttpPut]
        public void UpdateTask(TodoTask updatedTask)
        {
            _todoService.UpdateTask(updatedTask);
        }

        [HttpDelete("{id}")]
        public void DeleteTask(int id)
        {
            _todoService.DeleteTask(id);
        }
    }
}
