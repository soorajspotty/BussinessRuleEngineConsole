using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleProcessor.EmailService
{
    /// <summary>
    /// Interface to access email services
    /// </summary>
    interface IEmailService
    {
        bool SendEmail(string messgae);
    }
}
