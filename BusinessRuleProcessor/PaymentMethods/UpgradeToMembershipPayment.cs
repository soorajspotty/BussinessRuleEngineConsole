using BusinsessConstants;

namespace BusinessRuleProcessor.PaymentMethods
{
    class UpgradeToMembershipPayment : IPaymentService
    {
        public string ProcessPaymenRequest()
        {
            return (Constants.UpgradeToMembershipPaymentSuccessMessage);
        }
    }
}
