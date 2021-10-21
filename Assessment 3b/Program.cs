using System;
using System.Collections.Generic;

namespace Assessment_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> Customers = new List<Customer>
            {
                new Customer(true),
                new Customer(true),
                new Customer(true),
            };
            Restaurant redOlive = new Restaurant();
            Console.WriteLine(redOlive.ServeFamily(Customers));
            foreach(Customer c in Customers)
            {
                Console.WriteLine(c.Hunger);
            }
        }
    }
}

