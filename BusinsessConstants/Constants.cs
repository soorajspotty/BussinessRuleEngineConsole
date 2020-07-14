using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinsessConstants
{
    public static class Constants
    {
        public const string PhysicalProductPayment = "Physical Product Payment";
        public const string BookPayment = "Book Payment";
        public const string MembershipPayment = "Membership Payment";
        public const string UpgradeToMembershipPayment = "Upgrade To Membership Payment";
        public const string VideoPayment = "Video Payment";

        public const string PhysicalProductPaymentSuccessMessage = "Payment Successfull & Genererated a packaging slip for shipping & Agent Commision generated";
        public const string BookPaymentSuccessMessage = "Payment Successfull & Created duplicate packaging slip for shipping royality department";
        public const string MembershipPaymentSuccessMessage = "Payment processed & Activated membership";
        public const string UpgradeToMembershipPaymentSuccessMessage = "Membership upgraded and Confirmation Email send";
        public const string VideoPaymenSuccessMessage = "Payment Successfull & Added a Free Aid video to packing slip";


        public const string UpgradeToMembershipPaymentFailureMessage = "Membership upgade failed";
        public const string PhysicalProductPaymentFailureMessage = "Physical Product payment failed";

        //Form a static readonly payment options dictionary to be used anywhere in application.
        public readonly static Dictionary<int, string> DictPaymentMethods = new Dictionary<int, string>()
        {
            { 1, PhysicalProductPayment},
            { 2, BookPayment},
            { 3, MembershipPayment},
            { 4, UpgradeToMembershipPayment},
            { 5, VideoPayment}
        };
    }
}
