using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    public class ShoppingMall
    {
        public string CustomerName { get; set; }
        public int BillAmount { get; set; }

        public IStrategy CurrentStrategy;
        public ShoppingMall(IStrategy NewStrategy)
        {
            CurrentStrategy = NewStrategy;
        }

        public int GetFinalBill()
        {
            return CurrentStrategy.GetFinalBill(this.BillAmount);
        }
    }
}
