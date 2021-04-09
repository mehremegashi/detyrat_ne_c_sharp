using System;

namespace detyra3
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.Write("Shkruaj nje numer hexadecimal: ");
            //string nrHexa = Console.ReadLine();
            //int nrDecimal = Convert.ToInt32(nrHexa, 16);
            //Console.WriteLine("Numri hexadecimal {0} ne decimal eshte {1}", nrHexa, nrDecimal);


            Console.Write("Shkruaj nje numer hexadecimal: ");
            string nrHexa = Console.ReadLine();
            int hex = Convert.ToInt32(nrHexa, 16);
            string nrBinar = Convert.ToString(hex, 2);
            Console.WriteLine("Numri hexadecimal {0} ne numer binare eshte {1}", nrHexa, nrBinar);
        }
    }
}



//static void conversion(string value)
//{
//    Console.WriteLine("{0} to decimal is {1}.",
//        value, Convert.ToInt32(value, 16));
//    Console.WriteLine("{0} to decimal is {1}.\n", value,
//        Convert.ToString(Convert.ToInt32(value, 16), 2));
//}

//static void Main(string[] args)
//{
//    conversion("2A3E");
//    conversion("FA");
//    conversion("FFFF");
//    conversion("5A0E9");
//}
