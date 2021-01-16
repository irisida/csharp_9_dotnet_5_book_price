using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;

            Console.Write("Enter the number of items: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out count))
            {
                Console.WriteLine($"We have {count} items");
            }
            else
            {
                Console.WriteLine("Could not parse input");
            }
        }
    }
}
