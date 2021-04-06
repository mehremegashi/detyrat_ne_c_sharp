using System;

namespace detyra16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.Write("Enter p: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter q: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());


            if (p > q)
            {
                int oldValue = p;
                p = q;
                q = oldValue;
            }

            if (p + k >= q)
            {
                k += p - q - 1;
                q += p + k + 1;
            }

            number = ModifyNumber(number, p, q, k);

            Console.WriteLine(number);
        }
    }
}
