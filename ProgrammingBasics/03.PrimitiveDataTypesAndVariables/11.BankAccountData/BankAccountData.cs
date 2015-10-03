using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter First name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please enter Middle name: ");
            string middleName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please enter Last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please enter Money balance: ");
            decimal moneyBalance = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please enter Bank name: ");
            string bankName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please enter IBAN: ");
            string iban = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please enter credit card number: ");
            uint creditCardOne = uint.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter credit card number: ");
            uint creditCardTwo = uint.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter credit card number: ");
            uint creditCardThree = uint.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Account owner: " + firstName + middleName + lastName);
            Console.WriteLine("Money balance: " + moneyBalance);
            Console.WriteLine("Bank: " + bankName);
            Console.WriteLine("IBAN: " + iban);
            Console.WriteLine("Credit card 1: " + creditCardOne);
            Console.WriteLine("Credit card 2: " + creditCardTwo);
            Console.WriteLine("Credit card 3: " + creditCardThree);
        }
    }
}
