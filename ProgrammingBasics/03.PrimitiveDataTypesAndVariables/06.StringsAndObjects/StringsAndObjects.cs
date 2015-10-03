using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            String hello = "Hello ";
            String world = "World";
            object concatenation = hello + " " + world;

            string finalOutput = (string)concatenation;
            Console.WriteLine(finalOutput);


        }
    }
}
