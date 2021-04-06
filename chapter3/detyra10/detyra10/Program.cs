using System;

namespace detyra10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int a = (number / 1000) % 10;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;
            
            
            

            Console.WriteLine("1.Sum of digits = {0}", a + b + c + d);
            Console.WriteLine("2.Digits backwards {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("3.Last digit in first place {0}{1}{2}{3}", d, a,b,c);
            Console.WriteLine("4.Exchanges the second and the third digits {0}{1}{2}{3}", a, c, b, d);
            Console.ReadKey();

        }
    }
}
