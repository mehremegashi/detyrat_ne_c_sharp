using System;

namespace detyra5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            Console.WriteLine("{0} to decimal is {1}.",binary, Convert.ToInt32(binary, 2));
        }
    }
}
