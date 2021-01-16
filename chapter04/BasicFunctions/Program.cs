using System;
using System.Xml;

namespace BasicFunctions
{
    class Program
    {
        /*
         * fairly omnipresent times table example to demonstrate functions.
         * this demos how to offload the work to a function, the function
         * itself handles the console output.
         */

        static void Main(string[] args)
        {
            int tables;

            Console.Write("Enter how many multiplier tables we need: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out tables))
            {
                for (int i = 1; i <= tables; i++)
                {
                    WriteTable(i);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input received, could not parse");
            }
        }

        public static void WriteTable(int x)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(
                    format: "{0, 2} x {1, 2} = {2, 3}",
                    arg0: x,
                    arg1: i,
                    arg2: x * i
                );
            }
        }
    }
}
