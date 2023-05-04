using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    internal class lists
    {
        List<string> list;
        public void listvalues()
        {
            list=new List<string>(2);
            list.Add("1");
            list.Add("venky");
            list.Add("3.98");
            list.Add("sai");
            list.Add("lucky");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);

            }
            
        }
    }
}
