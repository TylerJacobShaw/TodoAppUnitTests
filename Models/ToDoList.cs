using System.Collections.Generic;
using System.Linq;
using ToDoApp.Models;

namespace ToDoApp.Tests
{
    public class ToDoList
    {
        List<TaskItem> _tasks = new List<TaskItem>();
        public ToDoList()
        {
        }
        public void AddTask(TaskItem task)
        {
            _tasks.Add(task);
        }

        public void RemoveTask(TaskItem task)
        {
            _tasks.Remove(task);
        }

        public List<TaskItem> GetTasks()
        {
            return _tasks;
        }
    }
}