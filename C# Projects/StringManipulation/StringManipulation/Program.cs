using System;
using System.Runtime.InteropServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;


namespace Program
{
    class Program
    {
        //test
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Enter a Sentence:");
            string x = Console.ReadLine();
            Console.WriteLine(x.ToUpper());
            Console.WriteLine(x.ToLower());
            bool checker = x.EndsWith("!");
            Console.WriteLine(checker);
            Console.WriteLine($"{x.ToLower()} {x.ToUpper()}");

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(x);
            stringBuilder.Append("!");
            Console.WriteLine(stringBuilder);
            Console.WriteLine(stringBuilder);

            string[] withEmptyEntries = x.Split(new[] { ',' }, StringSplitOptions.None);
            Console.WriteLine(withEmptyEntries);
            foreach (string entry in withEmptyEntries)
            {
                Console.WriteLine(entry);


            }

            for (int i = 0; i < withEmptyEntries.Length; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Enter Number");
            string Number = Console.ReadLine();
            int integernumber = int.Parse(Number);
           
            if (integernumber == withEmptyEntries.Length)
            {
                Console.WriteLine("You have chose the correct number!");
            }
            else
            {
                Console.WriteLine("Wrong Number");
            }






        }

    }
}