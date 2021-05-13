using System;

namespace detyra8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number");
            int c = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fourth number");
            int d = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fifth number");
            int e = Int32.Parse(Console.ReadLine());

            if (a > b && a > c && a > d && a > e) Console.WriteLine("{0} eshte me i madhi", a);
            else if (b > a && b > c && b > d && b > e) Console.WriteLine("{0} eshte me i madhi", b);
            else if (c > a && c > b && c > d && c > e) Console.WriteLine("{0} eshte me i madhi", c);
            else if (d > a && d > b && d > c && d > e) Console.WriteLine("{0} eshte me i madhi", d);
            else if (e > a && e > b && e > c && e > d) Console.WriteLine("{0} eshte me i madhi", e);
            else Console.WriteLine("ska numer me te madh.");
        }
    }
}
