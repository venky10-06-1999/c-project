using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCSharp
{
    internal class Dictonary
    {
        Dictionary<int,string> dict=new Dictionary<int, string>();

        int[] arr=new int[10];

        List<int> list=new List<int>(10);
       
        public void dictmethod()
        {
            dict.Add(1, "venky");
            dict.Add(2, "sai");
            foreach(var key in dict)
            {
                Console.WriteLine("values in {0}",key);
            }
        }

        public void customer2()
        {
            Dictionary<int,Customer> custdect = new Dictionary<int,Customer>();

            Customer customer1 = new Customer() { id = 1, name = "venky", email = "venky@gmail.com" };
            Customer customer2 = new Customer() { id = 2, name = "sai", email = "sai@gmail.com" };
            Customer customer3 = new Customer() { id = 3, name = "lucky", email = "lucky@gmail.com" };
            custdect.Add(customer1.id, customer1);
            custdect.Add(customer2.id, customer2);
            custdect.Add(customer3.id, customer3);
            foreach (var x in custdect)
            {
                Console.WriteLine("custer values are {0} {1} {2} {3}",x.Value.id,x.Value.name,x.Value.phone,x.Value.email);
            }

           

        }
    }

    public class Customer
    {
        public int id { get; set; }

        public string? name { get; set; }

        public string? email { get; set; }

        public string? phone { get; set; }

        public string? city { get; set; }
    }
}
