﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleProcessor.EmailService
{
    /// <summary>
    /// Class that provides services for sending Emails on request
    /// </summary>
    class EmailHelper : IEmailService
    {
        public bool SendEmail(string messgae)
        {
            return true;
        }
    }
}
