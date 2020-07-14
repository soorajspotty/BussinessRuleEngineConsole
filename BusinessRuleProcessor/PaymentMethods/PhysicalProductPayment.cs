using BusinessRuleProcessor.AgentCommission;
using BusinsessConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleProcessor.PaymentMethods
{
    /// <summary>
    /// Physical Product Payment handling module
    /// </summary>
    class PhysicalProductPayment : IPaymentService
    {
        IAgentCommision agentCommisionGenerator = null;
        public string ProcessPaymenRequest()
        {
            string returnMessage = string.Empty;
            agentCommisionGenerator = new AgentCommisionService();
            if (agentCommisionGenerator.GenerateAgentCommision(10))
            {
                returnMessage = Constants.PhysicalProductPaymentSuccessMessage;
            }
            else
            {
                returnMessage = Constants.PhysicalProductPaymentFailureMessage;
            }
            
            return returnMessage;
        }
    }
}
