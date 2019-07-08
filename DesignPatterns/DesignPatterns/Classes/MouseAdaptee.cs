using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    public class MouseAdaptee
    {
        public void ConnectB()
        {
            Console.WriteLine("Sending signal to USB Adapter");
        }
    }
}
