using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HellowWorld.Classes;
using IntermediateCSharp.Classes;

namespace IntermediateCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "Adam";

            person.Introduce("Daniel");

            var secondPerson = Person.Parse("Justinian");

            secondPerson.Introduce("Sebastian");

            System.Console.WriteLine("----------------------");

            var customer = new Customer(1);

            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Orders);
        }
    }
}