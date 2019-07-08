using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    public class LaptopFactory : IComputerAbstractFactory
    {
        public IComputer createComputer()
        {
            return new Laptop(this.RAM, this.HDD);
        }

        private string RAM;
        private string HDD;

        public LaptopFactory(string ram, string hdd)
        {
            this.RAM = ram;
            this.HDD = hdd;
        }
    }
}
