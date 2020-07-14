using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleProcessor.EmailService
{
    interface IEmailService
    {
        bool SendEmail(string messgae);
    }
}
