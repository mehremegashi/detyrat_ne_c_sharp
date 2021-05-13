using System;

namespace detyra15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a hex number");
            int hexnr = Console.ReadLine();
            string decnr = Convert.ToInt32(hexnr, 16);
            Console.WriteLine(hexnr + " ne decimal eshte " + decnr);
        }
    }
}

