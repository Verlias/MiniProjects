using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the first number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the second number:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int sum = AddNumbers(firstNumber, secondNumber);
        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {sum}.");
    }

    static int AddNumbers(int num1, int num2)
    {
        return num1 + num2;
    }
}