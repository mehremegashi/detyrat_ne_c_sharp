using System;

namespace detyra12
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 350;
            int p = 350;
            int mask = 1 << p;
            bool isOne = (v & mask) != 0 ? true : false;
            Console.WriteLine("The bit at position {0}of number {1} is 1? {2}", p, v, isOne);
        }
    }
}
