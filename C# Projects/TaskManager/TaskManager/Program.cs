using System;
using TaskClassNS;
using TaskListClassNS;

namespace ProgramNS
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskClass mytask = new TaskClass("Logan", "eat chicken", "07/03/2024", "high");
            mytask.DisplayDetails();

            TaskList list = new TaskList();

            list.AddTask(mytask);
            list.DisplayAllTasks();
            list.RemoveTask(mytask);
            list.DisplayAllTasks();

            Console.WriteLine("Hello World");
        }
    }
}
