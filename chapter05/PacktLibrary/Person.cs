using System;
using System.Collections.Generic;


namespace Packt.Shared
{
    public class Person : System.Object
    {
        public readonly DateTime Instantiated;
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

        public Person()
        {
            Name = "Not Set";
            Instantiated = DateTime.Now;
        }

    }
}
