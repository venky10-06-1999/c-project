using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    public class loops
    {
        public static void loopss()
        {
            int index = 0;
            while(index<5)
            {
                Console.WriteLine("while loop");
                index++;
            }
            Console.WriteLine(index);
            //do-while

            do
            {
                index = index + 1;
                Console.WriteLine("do-while loop");
            } while (index < 5);

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
