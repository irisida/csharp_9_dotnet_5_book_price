using System;

namespace DefaultValues
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * explore null in c#
             */

            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");
        }
    }
}
