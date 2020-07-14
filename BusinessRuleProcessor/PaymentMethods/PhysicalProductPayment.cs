using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleProcessor.PaymentMethods
{
    class PhysicalProductPayment : IPaymentService
    {
        public string ProcessPaymenRequest()
        {
            return ("Payment Successfull & Genererated a packaging slip for shipping");
        }
    }
}
