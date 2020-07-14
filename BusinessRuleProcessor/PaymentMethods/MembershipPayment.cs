using BusinsessConstants;

namespace BusinessRuleProcessor.PaymentMethods
{
    class MembershipPayment : IPaymentService
    {
        public string ProcessPaymenRequest()
        {
            return (Constants.MembershipPaymentSuccessMessage);
        }
    }
}
