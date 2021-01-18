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
            Console.WriteLine(person.ToString());
        }
    }
}
