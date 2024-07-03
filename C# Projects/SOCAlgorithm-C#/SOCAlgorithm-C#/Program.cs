using System;

namespace SOCAlgorithm
{

   class Program
    {
        static void Main(string[] args)
        {
          //
          for (int i = 100;  i < 1000; i++)
            {
                int OnesDigit = i % 10;
                int TensDigit = ((i / 10) % 10);
                int HundredsDigit = i / 100;
                int Sum = Cube(OnesDigit) + Cube(TensDigit) + Cube(HundredsDigit);

                if (Sum == i)
                {
                    Console.WriteLine("Found a Match: \n" + Sum);
                    
                }



            }
        }

        public static int Cube(int x)
        {
            return x * x * x;
        }
    }
}

// Goes from 0 to 100
// Finds a three digit number thats the sum of the cubes of its digits