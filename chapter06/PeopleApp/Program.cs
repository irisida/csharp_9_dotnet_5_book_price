using System;
using Packt.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person { Name = "Harry" };
            var mary = new Person { Name = "Mary" };
            var jill = new Person { Name = "Jill" };

            var baby1 = mary.ProcreateWith(harry);
            baby1.Name = "bucktooth";

            var baby2 = Person.Procreate(harry, jill);

            Console.WriteLine($"{harry.Name} has {harry.Children.Count} children");
            Console.WriteLine($"{mary.Name} has {mary.Children.Count} children");
            Console.WriteLine($"{jill.Name} has {jill.Children.Count} children");

            Console.WriteLine(
                format: "{0}'s first child is named \"{1}\".",
                arg0: harry.Name,
                arg1: harry.Children[0].Name
            );
        }
    }
}
