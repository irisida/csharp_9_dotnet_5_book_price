using System;

namespace FactorialsWithRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine($"{i}! = {Factorial(i):N0}");
            }
        }

        /// <summary>
        /// Expects an int to be passed in and it will return the factorial value using a recursive implementation.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>An int as the final result of calculating the factorial</returns>
        static int Factorial(int number)
        {
            if (number < 1)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                // uncomment to see recursive calls in action
                // Console.WriteLine($"calling {number} * Fractorial({number - 1})");
                return number * Factorial(number - 1);
            }
        }
    }
}
