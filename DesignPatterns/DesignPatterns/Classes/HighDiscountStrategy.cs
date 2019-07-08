using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    public class HighDiscountStrategy : IStrategy
    {
        int IStrategy.GetFinalBill(int BillAmount)
        {
            return (int)(BillAmount - (BillAmount * 0.5));
        }
    }
}
