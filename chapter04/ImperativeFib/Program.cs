using System;

namespace ImperativeFib
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 30; i++)
            {
                Console.WriteLine(
                    format: "The {0} term of the Fibonacci sequence is: {1:N0}",
                    arg0: CardinalToOrdinal(i),
                    arg1: GetNextImperativeFib(i)
                );
            }
        }

        static int GetNextImperativeFib(int term)
        {
            if (term == 1)
            {
                return 0;
            }
            else if (term == 2)
            {
                return 1;
            }
            else
            {
                return GetNextImperativeFib(term - 1) + GetNextImperativeFib(term - 2);
            }
        }

        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    int lastDigit = number % 10;

                    string suffix = lastDigit switch
                    {
                        1 => "st",
                        2 => "nd",
                        3 => "rd",
                        _ => "th"
                    };
                    return $"{number}{suffix}";
            }
        }
    }
}
