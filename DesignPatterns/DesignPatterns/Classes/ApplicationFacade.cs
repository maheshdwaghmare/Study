using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    class ApplicationFacade
    {
        Applicant _applicant;
        FormValidation _formValidation;
        BackgroundValidation _backgroundValidation;
        FeeValidation _feeValidation;
        public ApplicationFacade(Applicant applicant)
        {
            _applicant = applicant;
            _formValidation = new FormValidation(applicant);
            _feeValidation = new FeeValidation(applicant);
            _backgroundValidation = new BackgroundValidation(applicant);
        }

        public bool IsValidationDone()
        {
            if (_formValidation.IsFormDataValid() && _feeValidation.IsFeeReceived() && _backgroundValidation.IsApplicationEligible())
                return true;
            return false;
        }
    }
}
