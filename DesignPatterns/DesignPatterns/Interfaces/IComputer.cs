using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interfaces
{
    public interface IComputer
    {
        string getRAM();
        string getHDD();
        string getCPU();
    }
}
