using System;

namespace detyra6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter decimal number:");
            int deci = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} to hexadecimal is {1}", deci, deci.ToString("x"));
        }
    }
}
