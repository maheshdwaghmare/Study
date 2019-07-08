using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    public abstract class Pizza
    {
        public void MakePizza()
        {
            MakeDough();
            AddTomatoeSauce();
            AddCheese();
            AddToppings();
        }

        public void MakeDough()
        {
            Console.WriteLine("Worked the dough");
        }

        public void AddCheese()
        {
            Console.WriteLine("Adding Cheese");
        }

        public void AddTomatoeSauce()
        {
            Console.WriteLine("Adding Tomatow Sauce");
        }

        public abstract void AddToppings();
    }
}
