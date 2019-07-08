using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL: IBL
    {   
        IDAL _idal;
        public BL(IDAL dal)
        {
            _idal = dal;
        }
        
        public string GetBusinessData()
        {
            return _idal.GetData();
        }
    }
}
