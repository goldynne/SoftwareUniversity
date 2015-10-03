using System;
class PrintASequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ", ");
            }
            else
            {
                Console.Write("-" + i + ", ");
            }
        }
        Console.WriteLine();
    }
}

