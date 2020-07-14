using BusinsessConstants;

namespace BusinessRuleProcessor.PaymentMethods
{
    class VideoPayment : IPaymentService
    {
        public string ProcessPaymenRequest()
        {
            return (Constants.VideoPaymenSuccessMessage);
        }
    
    }
}
