using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DepedencyInjection
{
    public class Initiator
    {
        IBL _ibl;
        public Initiator(IBL ibl)
        {
            _ibl = ibl;
        }
        public string FetchData()
        {
            return _ibl.GetBusinessData();
        }
    }
}
