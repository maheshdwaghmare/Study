using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    class FeeValidation
    {
        Applicant _applicant;
        public FeeValidation(Applicant applicant)
        {
            _applicant = applicant;
        }
        public bool IsFeeReceived()
        {
            Console.WriteLine("Fee validation successful");
            return true;
        }
    }
}
