using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_3b
{
    class Restaurant
    {
        List<Chef> Employees;
        public Restaurant()
        {
            Employees = new List<Chef> {
            new Chef("Steve"),
            new Chef("Stacy"),
            new Chef("Hannah"),
        };

        }

        public bool ServeFamily(List<Customer> customers)
        {
            int totalHunger = 0;
            int totalFood = 0;
            foreach(Customer h in customers)
            {
                totalHunger += h.Hunger;
            }
            foreach (Chef f in Employees)
            {
                totalFood += f.Food;
            }
            if(totalHunger > totalFood)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
