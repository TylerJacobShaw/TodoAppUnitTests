using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }

        public TaskItem(int id, string description)
        {
            Id = id;
            Description = description;
            IsComplete = false;
        }

        public void MarkAsComplete()
        {
            IsComplete = true;
        }
    }
}
