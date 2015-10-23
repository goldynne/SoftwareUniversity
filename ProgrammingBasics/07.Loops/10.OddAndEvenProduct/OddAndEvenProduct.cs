using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            //Problem 10. Odd and Even Product

            //You are given n integers (given in a single line, separated by a space).
            //Write a program that checks whether the product of the odd elements is equal 
            //to the product of the even elements.
            //Elements are counted from 1 to n, so the first element is odd, the second is even, etc.


            int productOfOdds = 1;
            int productOfEvens = 1;

            for (int i = 0; i < values.Length; i++)
            {
                int currentValue = int.Parse(values[i]);
                if (i % 2 == 0)
                {
                    productOfEvens *= currentValue;
                }
                else
                {
                    productOfOdds *= currentValue;
                }
            }

            bool isEqual = productOfOdds == productOfEvens;

            if (isEqual == true)
            {
                Console.WriteLine("Yes!!!");
            }
            else
            {
                Console.WriteLine("No !!!");
            }
        }
    }
}
