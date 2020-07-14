using BusinessRuleProcessor.EmailService;
using BusinsessConstants;
using System.Text.RegularExpressions;

namespace BusinessRuleProcessor.PaymentMethods
{
    /// <summary>
    /// Upgrade To Membership Payment handling module
    /// </summary>
    class UpgradeToMembershipPayment : IPaymentService
    {
        IEmailService iEmailService = null;
        public string ProcessPaymenRequest()
        {
            string returnMessage = string.Empty;
            iEmailService = new EmailHelper();
            if(iEmailService.SendEmail(Constants.UpgradeToMembershipPaymentSuccessMessage))
            {
                returnMessage = Constants.UpgradeToMembershipPaymentSuccessMessage;
            }
            else
            {
                returnMessage = Constants.UpgradeToMembershipPaymentFailureMessage;
            }
            return returnMessage;
        }
    }
}
