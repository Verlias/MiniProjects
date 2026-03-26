using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");
            // // Console.Read();
            // // byte userAge = 20; 
            // // int numberOfEmployees = 510;

            // //Would get an error if this is written
            // // byte userAge2 = 20.0;
            // //Outputs 3
            // Console.WriteLine(7 / 2);
            // //Outputs 3.5
            // Console.WriteLine(7 / 2.0);
            // //Outputs 3.5
            // Console.WriteLine(7.0 / 2.0);
            // int x = 20;
            // Console.WriteLine(x);
            // int y = (int) 20.9;
            // Console.WriteLine(y);

            // Console.WriteLine("----");
            // int[] userAge = {21, 22, 23, 24, 25};
            // foreach (int age in userAge)
            // {
            //     Console.WriteLine(age);
            // }

            // //Holds a fixed number of values.
            // int [] myArray = new int[10];
            // Console.WriteLine(myArray);

            // //Dynamic array
            // List<int> userAgeList = new List<int> {11, 21, 31, 41};
            // Console.WriteLine(userAgeList);

            // int userAge;
            // Console.Write("Please enter your age: ");
            // userAge = Convert.ToInt32(Console.ReadLine());

            // if (userAge < 0 || userAge > 100)
            // {
            //     Console.WriteLine("Invalid Age");
            //     Console.WriteLine("Age must be between 0 and 100");
            // }
            // else if (userAge < 18)
            // {
            //     Console.WriteLine("Sorry you are underage");
            // }
            // else if (userAge < 21)
            // {
            //     Console.WriteLine("You need parental consent");
            // }
            // else
            // {
            //     Console.WriteLine("Congratulations!");
            //     Console.WriteLine("You may sign up for the event!");
            // }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}