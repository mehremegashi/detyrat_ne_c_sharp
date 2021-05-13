using System;

namespace detyra7
{
    class Program
    {
        public static string Reverse(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();

            Console.WriteLine(Reverse(number));
        }
    }
}
//another try
//static void ReverseNumber ( int num)
//{
//    int reverse = 0;
//    while (num ! =0)
//    { int lastNum = num % 10;
//        reverse = reverse * 10 + lastNum;
//          num = num / 10;

//    }
//    Console.WriteLine("the reversed number is {0}", reverse);
//}
//static void Main(string[] args)
//{
//    Console.Write("write the number:");
//    ReverseNumberNumber(Convert.ToInt32(Console.ReadLine()));
//}
