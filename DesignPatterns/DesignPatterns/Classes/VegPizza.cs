using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    class VegPizza : Pizza
    {
        public override void AddToppings()
        {
            Console.WriteLine("Adding Veg Toppings");
        }
    }
}
