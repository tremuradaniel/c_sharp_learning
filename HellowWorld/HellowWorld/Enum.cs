using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysEnum = System.Enum;

namespace HellowWorld
{

    public enum ShippingMethods
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    public class Enum
    {
        public Enum()
        {
            var Method = ShippingMethods.Express;

            Console.WriteLine((int)Method);

            var methodId = 2;

            Console.WriteLine((ShippingMethods) methodId);
            Console.WriteLine(Method.ToString());

            var methodName = "Express";

            // parse - convert a string into a different type
            var shippingMethod = (ShippingMethods) SysEnum.Parse(typeof(ShippingMethods), methodName);

            Console.WriteLine(shippingMethod);
        }
    }
}
