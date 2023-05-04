using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
       
        public class deligatemini
        {
            public delegate void deligatemethod(int x);
            public void methoddeligate(int y)
            {
                Console.WriteLine("it is a deligate method");
            }
            public void methoddeligate1(int x)
            {
                Console.WriteLine("it is a deligate method with int value {0}", x);
            }
        }
    }


