using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL : IDAL
    {
        public string GetData()
        {
            string value = "From Data";
            return value;
        }
    }
}
