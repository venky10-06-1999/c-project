using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    public class enums
    {
        enum age
        {
            male,female,other
        }

        public void GetAge()
        {
            Console.WriteLine(age.male.ToString());
        }

    }
}
