﻿using System;
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

            // c# 8 features
            object[] passengers = {
                new FirstClassPassenger {AirMiles = 1_419 },
                new FirstClassPassenger {AirMiles = 16_500 },
                new BusinessClassPassenger(),
                new CoachClassPassenger { CarryOnKG = 25.7},
                new CoachClassPassenger { CarryOnKG = 0 },
            };

            foreach (object passenger in passengers)
            {
                // c# 8 specific syntax
                decimal flightCost = passenger switch
                {
                    FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
                    FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
                    FirstClassPassenger _ => 2000M,
                    BusinessClassPassenger _ => 1000M,
                    CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
                    CoachClassPassenger _ => 650M,
                    _ => 800M
                };

                Console.WriteLine($"Flight costs {flightCost:C} for {passenger}");

            }

            // immutability concept using class with init properties
            var SwissTony = new ImmutablePerson
            {
                FirstName = "Swiss Tony",
                LastName = "Foshizzle"
            };

            var car = new ImmutableVehicle
            {
                Brand = "Mazda 6",
                Color = "Slate Grey",
                Wheels = 4
            };

            var repaintedCar = car with { Color = "Graphite & Black" };
            Console.WriteLine("original color was {0}, new color is {1}", arg0: car.Color, arg1: repaintedCar.Color);


        }

        static void DisplayValues(Person p)
        {
            Console.WriteLine(
                format: "{0} was born on {1:dd, MMM, yyyy}. Record created at: {2:HH:mm:ss} on {2:dddd dd-MMM-yyyy}.",
                arg0: p.Name,
                arg1: p.DateOfBirth,
                arg2: p.Instantiated
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
