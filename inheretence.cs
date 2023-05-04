using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    internal class inheretence
    {
        public void method1()
        {
            Console.WriteLine("base class");
        }
    }

    internal class deriveclas :inheretence
    {
        public void method2()
        {
            Console.WriteLine("derived class");
        }
    }
}
