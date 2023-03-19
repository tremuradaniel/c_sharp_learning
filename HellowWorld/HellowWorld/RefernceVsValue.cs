using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld
{
    class RefernceVsValue
    {
        public static void test()
        {
            var a = 10;
            var b = a;

            b += 1;
            b++;

            Console.WriteLine(string.Format("a: {0}, b:{1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };

            var array2 = array1;

            array1[0] = 100;

            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
        }
    }
}
