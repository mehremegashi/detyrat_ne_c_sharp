using System;

namespace detyra7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, sum;
            bool validity = false;
            do
            {
                Console.WriteLine("enter the first number");
                validity = int.TryParse(Console.ReadLine(), out a);
            } while (!validity);

            do
            {
                Console.WriteLine("enter the second number");
                validity = int.TryParse(Console.ReadLine(), out b);
            } while (!validity);

            do
            {
                Console.WriteLine("enter the third number");
                validity = int.TryParse(Console.ReadLine(), out c);
            } while (!validity);

            do
            {
                Console.WriteLine("enter the fouth number");
                validity = int.TryParse(Console.ReadLine(), out d);
            } while (!validity);

            do
            {
                Console.WriteLine("enter the fifth number");
                validity = int.TryParse(Console.ReadLine(), out e);
            } while (!validity);

            sum = a + b + c + d + e;
            Console.WriteLine($"The sum of all numbers is: {sum}");
               

        }
    }
}
