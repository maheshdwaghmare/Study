using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    class NonVegPizza : Pizza
    {
        public override void AddToppings()
        {
            Console.WriteLine("Adding NonVeg Toppings");
        }
    }
}
