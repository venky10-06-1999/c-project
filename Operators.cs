using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    public class Operators
    {
        public static void operators()
        {
          /*  nullable data types
            nullable data types
            int intval = null;
            float floatval = null;
            char charval = null;
            string stringval = null;
            bool boolval = null;
            double doubleval = null; */

            //nullable data types

            int? intval = null;
            float? floatval = null;
            char? charval = null;
            string? stringval = null;
            bool? boolval = null;
            double? doubleval = null;

            Console.WriteLine("value of nullable type is {0}",intval);
            Console.WriteLine("value of nullable type is {0}", floatval);
            Console.WriteLine("value of nullable type is {0}", charval);
            Console.WriteLine("value of nullable type is {0}", stringval);
            Console.WriteLine("value of nullable type is {0}", boolval);
            Console.WriteLine("value of nullable type is {0}", doubleval);

            int intvalue1 = 10;
            int intvalue2 = 20;
            Console.WriteLine("Addition of {0} and {1} is {2}",intvalue1,intvalue2,intvalue1 + intvalue2);
            Console.WriteLine("substraction of {0} and {1} is {2}", intvalue1, intvalue2, intvalue1 - intvalue2);
            Console.WriteLine("multiplication of {0} and {1} is {2}", intvalue1, intvalue2, intvalue1 * intvalue2);
            Console.WriteLine("division of {0} and {1} is {2}", intvalue1, intvalue2, intvalue1 / intvalue2);
            Console.WriteLine("modulo diision of {0} and {1} is {2}", intvalue1, intvalue2, intvalue1 % intvalue2);


        }
    }
}
