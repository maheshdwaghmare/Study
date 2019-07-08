using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    public class ComputerFactory
    {
        public static IComputer createComputer(IComputerAbstractFactory caf)
        {
            return caf.createComputer();
        }
    }
}
