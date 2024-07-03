using System;

namespace TaskClassNS
{
    public class TaskClass
    {
        // Attributes
        private string TaskTitle = "";
        private string Description = "";
        private string DueDate = "";
        private string Priority = "";

        // Properties
        public string Task
        {
            get { return TaskTitle; }
            set { TaskTitle = value; }
        }

        public string DescriptionProp
        {
            get { return Description; }
            set { Description = value; }
        }

        public string DueDateProp
        {
            get { return DueDate; }
            set { DueDate = value; }
        }

        public string PriorityProp
        {
            get { return Priority; }
            set { Priority = value; }
        }

        // Constructor
        public TaskClass(string task, string description, string duedate, string priority)
        {
            this.TaskTitle = task;
            this.Description = description;
            this.DueDate = duedate;
            this.Priority = priority;
        }

        // Method to display task details
        public void DisplayDetails()
        {
            Console.WriteLine($"Title: {this.TaskTitle}\nDescription: {this.Description}\nDue Date: {this.DueDate}\nPriority: {this.Priority}\n");
        }
    }
}
