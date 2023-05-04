using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    internal class Lambda
    {
        public  void lambdamethod()
        {
            Dictionary<string, int> productList = new Dictionary<string, int>();

            productList.Add("Hard Disk", 1280);
            productList.Add("Monitor", 3000);
            productList.Add("SSD Disk", 3500);
            productList.Add("RAM", 2450);
            productList.Add("Processor", 7680);
            productList.Add("Bluetooth", 540);
            productList.Add("Keyboard", 1130);

            //Method 1
            var search1 = from x in productList
                         where x.Key.Contains("RAM")
                         select x;
            //Method 2
            var search = productList.Where(p => p.Key.Contains("RAM"));

            foreach (var result in search1)
            {
                Console.WriteLine("Product Name: {0}, Price: {1}", result.Key, result.Value);
            }

            foreach (var result in search)
            {
                Console.WriteLine("Product Name: {0}, Price: {1}", result.Key, result.Value);
            }

            Console.ReadKey();
        }
    }
}
    