using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    public class Arrays
    {
        public static void arrays()
        {
            int[] arraysvalues = new int[] { 1, 2, 3 };
            string[] stringsvalues = new string[] { "venky", "sai" };

            //for-loop

            for (int i = 0; i < stringsvalues.Length; i++)
            {
                Console.WriteLine("values in string list " + stringsvalues[i]);
            }

            //for-each

            foreach (int i in arraysvalues) 
            {
                Console.WriteLine("values in int list " + i);
            }



        }
    }
}
