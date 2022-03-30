using System;

namespace Multiplication_table_to_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j = 0;

            Console.WriteLine("Program mnoży liczby z pierwszego wiersza przez liczby z pierwszej kolumny i zestawia wyniki w formie tabelarycznej.");

            //i - kolumny
            for (i = 1; i <= 10; i++)
            {
                //j - wiersze
                for (j = 1; j <= 10; j++)
                {
                    Console.Write(" \t {0}", i * j);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
