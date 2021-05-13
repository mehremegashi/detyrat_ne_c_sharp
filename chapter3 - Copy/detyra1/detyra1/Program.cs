using System;

namespace detyra1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("shkruani nje numer:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool even = number % 2 == 0;
            Console.WriteLine("{0}", even);
           
        }

    }
    
}
