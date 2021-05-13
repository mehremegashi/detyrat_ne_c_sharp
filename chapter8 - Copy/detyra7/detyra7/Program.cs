using System;

namespace detyra7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a hexadecimal number:");
            string hexa = Console.ReadLine();
            Console.WriteLine("{0} is decimal to {1}", hexa, Convert.ToInt32(hexa, 16));
        }
    }
}
