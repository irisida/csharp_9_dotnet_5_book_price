using System;

namespace CheckForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * add a try catch exception handler with a nested directive to perform checked
             * instead of using the inbuilt functionality to wrap overflow exceptions and
             * bounce he value to the opposite end of its possible value spectrum
             */

            try
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    Console.WriteLine($"x is: {x}");

                    x++;
                    Console.WriteLine($"x is: {x}");

                    x++;
                    Console.WriteLine($"x is: {x}");

                    x++;
                    Console.WriteLine($"x is: {x}");
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
