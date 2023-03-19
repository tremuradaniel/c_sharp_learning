using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermediateCSharp.Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

         public Customer(int id)
         :this()
        {
            // :this() above means you use also invoke the simple 
            // constructor at line 14
            this.Id = id;
        }

        public Customer(int id, string name)
        :this(id)
        {
            this.Name = name;
            // :this(id) means you invoke constructor on line 19, and you don't
            // need the line below anymore
            // this.Id = id;
        }
    }
}
