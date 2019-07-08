using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class PCFactory : IComputerAbstractFactory
    {
        public IComputer createComputer()
        {
            return new PC(this.RAM, this.HDD, this.CPU);
        }

        private string RAM;
        private string HDD;
        private string CPU;

        public PCFactory(string ram, string hdd, string cpu)
        {
            this.RAM = ram;
            this.HDD = hdd;
            this.CPU = cpu;
        }
    }
}
