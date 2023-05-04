using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    public abstract class abclass
    {

        public abstract void MyProperty();

        public void admethod()
        {
            Console.WriteLine("it is a absract class");
        }
    }

    public class cls : abclass
    {
        public override void MyProperty()
        {
            Console.WriteLine("implementing absract class");
        }

    }
}
