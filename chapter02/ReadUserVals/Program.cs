using System;

namespace ReadUserVals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine($"Hello {firstName}");
        }
    }
}
