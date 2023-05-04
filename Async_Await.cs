using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    internal class Async_Await
    {

        public  async Task Method1()
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(" Method 1");

                        
                    }
                });
            }


            public void Method2()
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(" Method 2");

                }
            }
        }

    }
