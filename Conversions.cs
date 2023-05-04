using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    public class Conversions
    {
        public static void conversions()
        {
            /*it shows val1 result
            is it fine */


            int val1 = 12;
            float fval = val1;  //implicit conversion
            Console.WriteLine("int to float value" + val1);

            float fval1 = 1213.34f;
            //int val2 = fval1;
            int val2 = (int)fval1; //explicit conversion

            Console.WriteLine("float to int value " + val2);

            //using parse it will return value

            string sval = "121";
           //int ival3 = sval;
           //int ival4 = int(sval);
            int ival5=int.Parse(sval);
            Console.WriteLine("string to int value " + sval);

            //using tryParse()

            
            string sval1 = "1233";
            var val = int.TryParse(sval1,out int intval2);
            Console.WriteLine("tryparse value is " + val);
            Console.WriteLine("tryparse output value is " + intval2);
        }

    }
}
