using System;
using System.Globalization;

namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            CultureInfo myCultureInfo = new CultureInfo("us-US");
            Console.Write("Enter the time in format hh:mm tt: ");
            DateTime now = DateTime.Parse(Console.ReadLine());
            if (now.Hour < 13 && now.Hour > 3)
            {
                Console.WriteLine("non-beer time");
            }
            else
            {
                Console.WriteLine("beer time");
            }
        }
    }
}
