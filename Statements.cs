using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    public class Statements
    {
        public static void ifstatements()
        {
            int a = 11;
            int b = 21;
            string c = "sd";
            string d = "sd";

            if(a == 11)
            {
                Console.WriteLine("statement is true");
            }
            else
            {
                Console.WriteLine("statement is false");
            }

            //logical and

            if (a == 11  && b==21)
            {
                Console.WriteLine("statement is true");
            }
            else
            {
                Console.WriteLine("statement is false");
            }

            //logical or

            if (a == 11 & b == 22)
            {
                Console.WriteLine("statement is true");
            }
            else
            {
                Console.WriteLine("statement is false");
            }

            //logical or

            if (a == 11 || b == 22)
            {
                Console.WriteLine("statement is true");
            }
            else
            {
                Console.WriteLine("statement is false");
            }

            //logical or

            if (a == 12 | b == 21)
            {
                Console.WriteLine("statement is true");
            }
            else
            {
                Console.WriteLine("statement is false");
            }

            //switch statement
            Console.WriteLine("enter male,female or other");
            string vall = Console.ReadLine();
            switch(vall)
            {
                case "male":
                    Console.WriteLine("entered string is"+ vall);
                    break;
                case "female":
                    Console.WriteLine("entered string is" + vall);
                    break;
                case "other":
                    Console.WriteLine("entered string is" + vall);
                    break;
                    default:
                    Console.WriteLine("switch final");
                    break;


            }
        }
    }
}
