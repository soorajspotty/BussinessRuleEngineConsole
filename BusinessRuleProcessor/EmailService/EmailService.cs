using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleProcessor.EmailService
{
    class EmailHelper : IEmailService
    {
        public bool SendEmail(string messgae)
        {
            return true;
        }
    }
}
