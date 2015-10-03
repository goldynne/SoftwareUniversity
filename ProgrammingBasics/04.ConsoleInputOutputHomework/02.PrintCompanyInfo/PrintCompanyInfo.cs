using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrintCompanyInfo
{
    class PrintCompanyInfo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter company name: ");
            string companyName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter company's address: ");
            string companyAddress = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter company's phone number: ");
            int companyPhoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter company's fax number: ");
            int companyFaxNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter company's website: ");
            string companyWebsite = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter manager's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter manager's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter manager's age: ");
            int managerAge = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter manager's phone number: ");
            int managerPhone = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel: +359{0}", companyPhoneNumber);
            Console.WriteLine("Fax: {0}", companyFaxNumber);
            Console.WriteLine("Web site: http://{0}", companyWebsite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. +359{3})", firstName, lastName, managerAge, managerPhone);
        }
    }
}
