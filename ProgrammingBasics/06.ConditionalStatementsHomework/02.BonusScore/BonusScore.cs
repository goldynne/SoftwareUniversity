using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a score number: ");
            int score = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if ((score >= 10) || (score <= 0))
            {
                Console.WriteLine("invalid score");
            }

            if (score == 1 || score == 2 || score == 3)
            {
                score *= 10;
                Console.WriteLine(score);
            }
            else if (score == 4 || score == 5 || score == 6)
            {
                score *= 100;
                Console.WriteLine(score);
            }
            else if (score == 7 || score == 8 || score == 9)
            {
                score *= 1000;
                Console.WriteLine(score);
            }
        }
    }
}
