using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    public interface MyInterface
    {
        
        public void car();
        public void bike();

    }

    public class interfaceabc : MyInterface

    {
        public void bike()
        {
            Console.WriteLine("executing bike inteerface");
        }

        public void car()
        {
            Console.WriteLine( "executing car interface");
        }
    }

}
