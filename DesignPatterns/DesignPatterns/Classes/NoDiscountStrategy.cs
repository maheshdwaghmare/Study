using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    public class NoDiscountStrategy : IStrategy
    {
        int IStrategy.GetFinalBill(int BillAmount)
        {
            return BillAmount;
        }
    }
}
