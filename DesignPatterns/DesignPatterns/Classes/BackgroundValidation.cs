﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    class BackgroundValidation
    {
        Applicant _applicant;
        public BackgroundValidation(Applicant applicant)
        {
            _applicant = applicant;
        }
        public bool IsApplicationEligible()
        {
            Console.WriteLine("Background validation successful");
            return true;
        }
    }
}
