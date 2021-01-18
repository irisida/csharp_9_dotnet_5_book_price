using System;
using Packt.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Name = "Swiss Tony";
            p1.DateOfBirth = new DateTime(1973, 12, 30);
            p1.BucketList = WondersOfTheAncientWorld.GreatPyramidOfGiza |
                WondersOfTheAncientWorld.LighthouseOfAlexandria;


            // using formatted strings
            Console.WriteLine(
                format: "{0} was born on {1:dddd, d, MMMM, yyyy}.",
                arg0: p1.Name,
                arg1: p1.DateOfBirth
            );
            Console.WriteLine($"{p1.Name}'s bucket list is: {p1.BucketList}");

            var p2 = new Person();
            p2.Name = "Jac the hat";
            p2.DateOfBirth = new DateTime(1951, 1, 1);
            p2.BucketList = WondersOfTheAncientWorld.MausoleumAtHalicarnassus | WondersOfTheAncientWorld.TempleOfArtemisAtEphesus;

            Console.WriteLine(
                format: "{0} was born on {1:dd, MMM, yyyy}.",
                arg0: p2.Name,
                arg1: p2.DateOfBirth
            );
            Console.WriteLine($"{p2.Name}'s bucket list is: {p2.BucketList}");
        }
    }
}
