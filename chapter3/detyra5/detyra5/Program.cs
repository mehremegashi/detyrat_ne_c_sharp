using System;

namespace detyra5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine()); 
            double h = double.Parse(Console.ReadLine()); 
            Console.WriteLine("S ={0}", (a + b) / (2 * h));
        }
    }
}
