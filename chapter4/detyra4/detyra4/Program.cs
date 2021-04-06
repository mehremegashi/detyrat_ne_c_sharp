using System;

namespace detyra4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hexNumber = 2015;
            Console.WriteLine("|0x{0,-8:X|", hexNumber);
            double fractNumber = -1.856;
            Console.WriteLine("|0,-10:f2}|", fractNumber);
        }
    }
}
