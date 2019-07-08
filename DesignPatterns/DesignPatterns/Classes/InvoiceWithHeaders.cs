using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class InvoiceWithHeaders : IInvoice
    {
        public void Print()
        {
            Console.WriteLine("Print Invoice With Headers.");
        }
    }
}
