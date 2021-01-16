using System;

namespace MakeNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * add the '?' syntax to make a primitive type nullable.
             */

            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = 100;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
        }
    }
}
