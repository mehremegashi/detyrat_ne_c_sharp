using System;

namespace DetyraExtra
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for(int b = -6; b < 7; b++)
            {
                double a = Math.Pow(b, 2) - 2*b + 5;
                if (b < 0)
                {
                    Console.WriteLine($"a = ({b})^2 - 2 * ({b}) + 5 = {a}");
                }
                else
                {
                    Console.WriteLine($"a = {b}^2 - 2 * {b} + 5 = {a}");

                }
                
            }
        }
    }
}
