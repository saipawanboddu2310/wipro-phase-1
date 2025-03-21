﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo1
{
    internal class Program
    {
        class Customer
        {
            public int CustomerID { set; get; }
            public string CustomerGenericName { set; get; }
        }
        static void Main(string[] args)
        {
            Dictionary<string, int> dicobj = new Dictionary<string, int>();
            Console.WriteLine("\n enter number of elements in the dictionary ...");
            int counter = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("enter key:");
                string key = Console.ReadLine();
                Console.WriteLine("enter value:");
                int value = Convert.ToInt32(Console.ReadLine());
                dicobj.Add(key, value);
            }

            Console.WriteLine("\n Printing dictionary....");
            foreach (KeyValuePair<string, int> pair in dicobj)
            {
                Console.WriteLine($"{pair.Key}--{pair.Value}");
            }
            Console.WriteLine("which key is having largest length value");
            Console.WriteLine($"{dicobj.Values.Max()}");
            Dictionary<double, Customer> dicofcust = new Dictionary<double, Customer>()
            {
                {101.1,new Customer(){CustomerID=1001,CustomerGenericName="Kumar"} },
                {101.2,new Customer(){CustomerID=1002,CustomerGenericName="sita"} }
            }; 
            Console.WriteLine("\nprinting cusotmer dictionary:");
            foreach (var cusotmer in dicofcust)
            {

                Console.WriteLine($"{cusotmer.Key}:--->{cusotmer.Value.CustomerID},{cusotmer.Value.CustomerGenericName}");


            }
            Console.ReadLine();
        }
    }
}
