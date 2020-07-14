using BusinsessConstants;

namespace BusinessRuleProcessor.PaymentMethods
{
    /// <summary>
    ///  Class which handles processes involved in Book Payment
    /// </summary>
    class BookPayment : IPaymentService
    {
        public string ProcessPaymenRequest()
        {
            return (Constants.BookPaymentSuccessMessage);
        }
    }
}
