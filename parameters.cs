using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    public class parameters
    {
        //value parameters
        public void para(int a,int b)
        {
            a = 3;
            b = 4;
           
        }

        //ref parameters
        public void para1(ref int c,ref int d)
        {
            c = 3;
            d = 4;

        }

        //out parameters
        public void para2(int e,int f,out int g,out int h)
        {
            g = f;
            h = e;

        }

        //params 
        public void resultofparas(params int[] val)
        {
            foreach (int i in val)
            {
                Console.WriteLine(i);
            }

        }

    }
}
