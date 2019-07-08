using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{   
    public class PC : IComputer
    {
        private string RAM;
        private string HDD;
        private string CPU;
        public PC(string ram, string hdd, string cpu)
        {
            this.RAM = ram;
            this.HDD = hdd;
            this.CPU = cpu;
        }

        public string getRAM()
        {
            return this.RAM;
        }

        public string getHDD()
        {
            return this.HDD;
        }

        public string getCPU()
        {
            return this.CPU;
        }
    }
}
