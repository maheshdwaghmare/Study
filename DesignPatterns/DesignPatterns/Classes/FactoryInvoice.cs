using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class FactoryInvoice
    {
        public static IInvoice GetInvoice(int invoiceType)
        {
            IInvoice ObjInv;
            if (invoiceType == 1)
            {
                ObjInv = new InvoiceWithHeaders();
            }
            else if (invoiceType == 2)
            {
                ObjInv = new InvoiceWithoutHeaders();
            }
            else
            {
                return null;
            }

            return ObjInv;
        }
    }
}
