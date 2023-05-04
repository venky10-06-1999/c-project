using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    public class genericsbyclass<T>
    {
        public void genbyclassmethod(T val,T val2)
        {
            Console.WriteLine("generic by class {0} {1}",val,val2);
        }

        public static void genbyclassmethod11(T val3)
        {
            Console.WriteLine("generic by class {0}", val3);
        }

    }
}
