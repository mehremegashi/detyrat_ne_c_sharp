using System;

namespace detyra9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a binary number");
            string binary = Console.ReadLine();
            Console.WriteLine("{0} is hexadecimal to {1}", binary, Convert.ToInt32(binary, 2).ToString("X"));
        }
    }
}
