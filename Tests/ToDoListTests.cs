using System.Linq;
using ToDoApp.Models;
using Xunit;

namespace ToDoApp.Tests
{
    public class ToDoListTests
    {
        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            // Arrange
            var toDoList = new ToDoList();
            var task = new TaskItem(1, "Test task");

            // Act
            toDoList.AddTask(task);

            // Assert
            Assert.Contains(task, toDoList.GetTasks());
        }

        [Fact]
        public void RemoveTask_ShouldRemoveTaskFromList()
        {
            // Arrange
            var toDoList = new ToDoList();
            var task = new TaskItem(1, "Test task");
            var task2 = new TaskItem(2, "Test task 2");

            // Act
            toDoList.AddTask(task);
            toDoList.AddTask(task2);

            toDoList.RemoveTask(task2);

            // Assert
            Assert.DoesNotContain(task2, toDoList.GetTasks());
        }
    }
}
