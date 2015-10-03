using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            String firstName = "Amanda";
            String lastName = "Jonson";
            byte age = 27;
            char gender = 'f';
            ulong idNumber = 8306112507;
            uint employeeNumber = 27563571;

            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID number: " + idNumber);
            Console.WriteLine("Unique employee number: " + employeeNumber);
        }
    }
}
