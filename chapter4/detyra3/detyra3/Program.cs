using System;

namespace detyra3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Enter company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Enter company phone number: ");
            string companyPhone = Console.ReadLine();
            Console.Write("Enter company fax: ");
            string companyFax = Console.ReadLine();
            Console.Write("Enter company website: ");
            string companySite = Console.ReadLine();
            Console.Write("Enter company manager: ");
            string companyManager = Console.ReadLine();
            Console.Write("Enter manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Enter manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Enter manager phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("Firm: Name - {0}, Address - {1}, Number - {2}, Fax - {3}, Website - {4}, Manager - {5}", companyName, companyAddress, companyPhone, companyFax, companySite, companyManager);
            Console.WriteLine("Manager: Name - {0} {1}, Phone - {2}", managerFirstName, managerLastName, managerPhone);
        }
    }
}
