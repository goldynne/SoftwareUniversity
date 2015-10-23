using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type: ");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Please enter an int: ");
                    int enteredInt = int.Parse(Console.ReadLine());
                    enteredInt += 1;
                    Console.WriteLine();
                    Console.WriteLine(enteredInt);
                    break;
                case 2:
                    Console.Write("Please enter a double: ");
                    double enteredDouble = double.Parse(Console.ReadLine());
                    enteredDouble += 1;
                    Console.WriteLine();
                    Console.WriteLine(enteredDouble);
                    break;
                case 3:
                    Console.Write("Please enter a string: ");
                    string enteredString = Console.ReadLine();
                    enteredString += "*";
                    Console.WriteLine();
                    Console.WriteLine(enteredString);
                    break;
                default:
                    Console.WriteLine("Please choose option 1, 2 or 3.");
                    break;
            }
        }
    }
}
