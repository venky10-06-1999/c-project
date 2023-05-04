using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    struct Coordinate
    {
        public int x;
        public int y;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine(x + y);
        }

        public void GetOrigin()
        {
            Console.WriteLine("value of x and y");
        }
    }

   
}


