using System;

namespace ReadChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a key combination: ");

            ConsoleKeyInfo key = Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("key: {0}, Char: {1}, Modifiers: {2}", arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);
        }
    }
}
