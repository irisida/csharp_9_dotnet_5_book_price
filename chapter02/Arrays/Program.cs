using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            // run on the declared but empty array
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] != null)
                {
                    Console.WriteLine($"{names[i]}");
                }

            }

            names[0] = "Swiss Tony";
            names[1] = "Jack the hat";
            names[2] = "mad Ronnie";
            names[3] = "Danny the wheel";
            names[4] = "Chicken George";

            // run on an array that was assigned values
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]}");
            }

        }
    }
}
