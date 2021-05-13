using System;

namespace detyra8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";
            object obj = str1 + " " + str2;
            string str3 = obj.ToString();
            Console.WriteLine("{0} {1} \n {2}", str1, str2, obj);
        }
    }
}
