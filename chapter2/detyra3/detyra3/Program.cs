using System;

namespace detyra3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numri1 = 10.000001m;
            decimal numri2 = 10.000001m;
            
            Console.WriteLine(numri1.Equals(numri2));
        }
    }
}
