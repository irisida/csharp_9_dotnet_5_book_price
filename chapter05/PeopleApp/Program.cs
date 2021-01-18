using System;
using System.Globalization;
using Packt.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CultureInfo.CurrentCulture = new CultureInfo("en-GB", false);

            var p1 = new Person();
            p1.Name = "Swiss Tony";
            p1.DateOfBirth = new DateTime(1973, 12, 30);
            p1.BucketList = WondersOfTheAncientWorld.GreatPyramidOfGiza |
                WondersOfTheAncientWorld.LighthouseOfAlexandria;
            p1.Children.Add(new Person { Name = "Ronnie" });
            p1.Children.Add(new Person { Name = "Reggie" });

            DisplayValues(p1);

            var p2 = new Person();
            p2.Name = "Jac the hat";
            p2.DateOfBirth = new DateTime(1951, 1, 1);
            p2.BucketList = WondersOfTheAncientWorld.MausoleumAtHalicarnassus |
                WondersOfTheAncientWorld.TempleOfArtemisAtEphesus;
            p2.Children.Add(new Person { Name = "Ping-Pong" });
            p2.Children.Add(new Person { Name = "Wah-wah" });

            DisplayValues(p2);

            var p3 = new Person();
            p3.Name = "Mad Archie";
            p3.DateOfBirth = new DateTime(1966, 3, 3);
            p3.BucketList = WondersOfTheAncientWorld.MausoleumAtHalicarnassus |
                WondersOfTheAncientWorld.TempleOfArtemisAtEphesus;

            DisplayValues(p3);

            BankAccount.InterestRate = 0.022M;

            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs Jones";
            jonesAccount.Balance = 3600;

            Console.WriteLine(
                format: "{0} earned {1:C} interest",
                arg0: jonesAccount.AccountName,
                arg1: jonesAccount.Balance * BankAccount.InterestRate
            );
        }

        static void DisplayValues(Person p)
        {
            Console.WriteLine(
                format: "{0} was born on {1:dd, MMM, yyyy}.",
                arg0: p.Name,
                arg1: p.DateOfBirth
            );
            Console.WriteLine($"{p.Name}'s bucket list is: {p.BucketList}");

            if (p.Children.Count > 0)
            {
                Console.WriteLine($"{p.Name} has {p.Children.Count} children called:");

                for (int child = 0; child < p.Children.Count; child++)
                {
                    Console.WriteLine(p.Children[child].Name);
                }
            }
            else
            {
                Console.WriteLine($"{p.Name} has no children at this time.");
            }


        }
    }
}
