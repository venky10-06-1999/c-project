using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    internal class generics
    {
        public void genmethod(int x,int y)
        {
            Console.WriteLine("generic method {0} {1}",x,y);
        }

        public void stringmethod(string a,string b)
        {
            Console.WriteLine("generic method2 is {0} {1}",a,b);
        }

        public void genericmethod<T>(T p,T q)
        {
            Console.WriteLine("generic method");
        }
    }
}
