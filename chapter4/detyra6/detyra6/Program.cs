using System;

namespace detyra6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Second number:");
            double secondNumber = double.Parse(Console.ReadLine());

            double compareNumbers = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("Number {0} is greater", compareNumbers);
        }
    }
}
