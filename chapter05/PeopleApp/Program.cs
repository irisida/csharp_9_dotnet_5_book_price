using System;
using Packt.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Swiss Tony";
            person.DateOfBirth = new DateTime(1973, 12, 30);
            Console.WriteLine(
                format: "{0} was born on {1:dddd, d, MMMM, yyyy}",
                arg0: person.Name,
                arg1: person.DateOfBirth
            );

            var p2 = new Person();
            p2.Name = "Jac the hat";
            p2.DateOfBirth = new DateTime(1951, 1, 1);
            Console.WriteLine(
                format: "{0} was born on {1:dd, MMM, yyyy}",
                arg0: p2.Name,
                arg1: p2.DateOfBirth
            );
        }
    }
}
