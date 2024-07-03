using System;
using System.Collections.Generic;
using TaskClassNS;

namespace TaskListClassNS
{
    public class TaskList
    {
        private List<TaskClass> Tasks;

        public TaskList()
        {
            Tasks = new List<TaskClass>();
        }

        // Add Task
        public void AddTask(TaskClass task)
        {
            Tasks.Add(task);
            Console.WriteLine($"New Task has been added to the list.");
        }

        // Remove Task
        public void RemoveTask(TaskClass task)
        {
            if (Tasks.Remove(task))
            {
                Console.WriteLine($"Removed {task.GetType().Name} from the list.");
            }
            else
            {
                Console.WriteLine($"Task {task.GetType().Name} not found in the list.");
            }
        }

        // Display all Tasks
        public void DisplayAllTasks()
        {
            Console.WriteLine("List of all the Tasks:");
            foreach (var task in Tasks)
            {
                task.DisplayDetails();
            }
        }
    }
}
