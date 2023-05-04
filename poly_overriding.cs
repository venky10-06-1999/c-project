using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    public class poly_overriding
    {
        public virtual void method1()
        {
            Console.WriteLine("poly_overriding base class");
        }
    }

    public class poly_overriding1 : poly_overriding
    {
        public override void method1()
        {
            Console.WriteLine("poly_overriding derived class");
        }

        ////encapsulation

        //public new void method1()
        //{
        //    Console.WriteLine("poly_overriding derived class");
        //}
    }
}
