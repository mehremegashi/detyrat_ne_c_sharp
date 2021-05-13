
using System;

namespace detyra8
{
    class Program
    {
        public static void Main(string[] args)
        {
           
           
                Console.WriteLine("enter hexadecimal number");
                string hexa = Console.ReadLine();
                Console.WriteLine("{0} is hexadecimal to {1}.", hexa, (Convert.ToInt32(hexa, 16), 2));
        }
            
    }
}
