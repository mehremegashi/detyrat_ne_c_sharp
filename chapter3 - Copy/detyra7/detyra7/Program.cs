using System;

namespace detyra7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("this person will weight {0}kg in the moon", weight * 0.17);
        }
    }
}
