using System;

namespace NumberSeparators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * demonstrates the use of the separators on longer or complex number notation.
             */

            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;

            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{binaryNotation == hexadecimalNotation}");
        }
    }
}
