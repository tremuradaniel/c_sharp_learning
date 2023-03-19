using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HellowWorld.Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi, {0}! I'm {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            Person person = new Person();
            person.Name = str;

            return person;
        }
    }
}