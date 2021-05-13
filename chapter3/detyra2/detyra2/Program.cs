using System;

namespace detyra2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool check = number % 5 == 0 && number % 7 == 0 ? true : false ;
            if (check = true)
            {
                Console.WriteLine("the number {0} is divisible by 5 and 7", number);
            }
            else
            {
                Console.WriteLine("the number {0} is not divisible by 5 and 7", number);
            }
        }
    }

}