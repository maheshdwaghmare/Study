using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    class USBAdapter
    {
        MouseAdaptee mouseAdaptee = new MouseAdaptee();
        public void ConnectA()
        {
            mouseAdaptee.ConnectB();
            Console.WriteLine("Converting signal to USB");
            Console.WriteLine("Sending new converted signals to Computer");
        }
    }
}
