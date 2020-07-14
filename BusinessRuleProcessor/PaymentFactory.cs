using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRuleProcessor.PaymentMethods;

namespace BusinessRuleProcessor
{
    /// <summary>
    /// Class dedicated to provide payment object of requested payment service
    /// </summary>
    public class PaymentFactory
    {
        public static IPaymentService GetPaymentType(string paymentType)
        {
            IPaymentService iPaymentService = null;
            if (paymentType == "Physical Product Payment")
                iPaymentService = new PhysicalProductPayment();
            return iPaymentService;
        }
    }
}
