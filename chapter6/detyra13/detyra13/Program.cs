using System;
namespace detyra13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a bin number");
            int binnr = Console.ReadLine();
            string decnr = Convert.ToInt32(binnr, 2);
            Console.WriteLine(binnr + " ne decimal eshte " + decnr);
        }
    }
}

