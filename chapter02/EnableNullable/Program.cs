using System;

namespace EnableNullable
{
    class Address
    {
        public string? Building;
        public string Street = string.Empty; // not marked as nullable
        public string City = string.Empty;
        public string Region = string.Empty; // not marked as nullable
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address address = new();
            address.Building = null;
            address.Street = null; // warns as not nullable
            address.City = "London";
            address.Region = null; // warns as not nullable

            Console.WriteLine("Hello World!");
        }
    }
}
