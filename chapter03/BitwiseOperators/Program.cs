using System;

namespace BitwiseOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 6;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"a & b = {a & b}"); // binary and
            Console.WriteLine($"a | b = {a | b}"); // binary or
            Console.WriteLine($"a ^ b = {a ^ b}"); // binary xor
        }
    }
}
