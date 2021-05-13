using System;

namespace detyra3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("shkruani numrin e epare: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("shkruani numrin e dyte: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("shkruani numrin e trete: ");
            int c = Int32.Parse(Console.ReadLine());

            if (a > b)
                if (a > c) Console.WriteLine("A eshte me i madhi");
                else if (a < c) Console.WriteLine("C eshte me i madhi");
                else Console.WriteLine("A dhe C jane me te medhhenjte");
            else if (a < b)
                if (b > c) Console.WriteLine("B eshte me i madhi");
                else if (b < c) Console.WriteLine("C eshte me i madhit");
                else Console.WriteLine("B dhe C jane me te medhenjte");
            else if (a == b)
                if (a == c) Console.WriteLine("te gjithe jane te barabarte");
                else if (a < c) Console.WriteLine("C eshte me i madhi");
                else Console.WriteLine("numri i pare dhe numri i dyte jane me te medhenjte");
        }
    }
}
