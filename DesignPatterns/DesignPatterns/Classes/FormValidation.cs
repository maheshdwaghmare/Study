using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    class FormValidation
    {
        Applicant _applicant;
        public FormValidation(Applicant applicant)
        {
            _applicant = applicant;
        }
        public bool IsFormDataValid()
        {
            Console.WriteLine("Form validation successful");
            return true;
        }
    }
}
