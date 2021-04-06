using System;

namespace detyra13
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 10;

            int placeholder = number2;

            number2 = number1;
            number1 = placeholder;

            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }
    }
}
