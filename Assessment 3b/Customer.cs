using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_3b
{
    class Customer
    {
        public int Hunger;
        public bool Adult;

        public Customer(bool adult)
        {
            if(adult == true)
            {
                Hunger = 10;
            }
            else
            {
                Hunger = 5;
            }
            Adult = adult;
            
        }
    }
}
