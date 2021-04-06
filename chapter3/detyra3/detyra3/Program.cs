using System;

namespace detyra3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("shkruani nje numer:");
            int number = int.Parse(Console.ReadLine());
            int thirdDigit = (number / 100) % 10 ;
            if (thirdDigit == 7) 
            { 
            Console.WriteLine("numri i trete eshte shtate");
            }
        else
            {
             Console.WriteLine("numri i trete nuk eshte shtate");
            }
            Console.ReadKey();
        }
    }
}
