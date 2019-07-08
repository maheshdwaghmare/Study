using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class ServerFactory : IComputerAbstractFactory
    {
        public IComputer createComputer()
        {
            return new Server(this.RAM, this.HDD, this.CPU);
        }

        private string RAM;
        private string HDD;
        private string CPU;

        public ServerFactory(string ram, string hdd, string cpu)
        {
            this.RAM = ram;
            this.HDD = hdd;
            this.CPU = cpu;
        }
    }
}
