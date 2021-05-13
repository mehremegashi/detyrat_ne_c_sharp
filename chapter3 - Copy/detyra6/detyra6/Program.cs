using System;

namespace detyra6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter h:");
            double h = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * (a + h);
            double area = a * h;
            Console.WriteLine("perimetri{0} \nsiperfaqja{1}" , perimeter,area);
        }
    }
}
