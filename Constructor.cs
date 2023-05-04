using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace projectCSharp
{
    public class Constructor
    {
        private readonly string _firstname;
        private readonly string _lastname;
        public Constructor(string firstname,string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
        }
        public void constructor()
        {
            Console.WriteLine("firstname and lastname is {0} {1} ",_firstname,_lastname);
        }
    }
}
