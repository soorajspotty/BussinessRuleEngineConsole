﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRuleProcessor.PaymentMethods;
using BusinsessConstants;

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
            if (paymentType == Constants.PhysicalProductPayment)
                iPaymentService = new PhysicalProductPayment();
            if (paymentType == Constants.BookPayment)
                iPaymentService = new BookPayment();
            if (paymentType == Constants.MembershipPayment)
                iPaymentService = new MembershipPayment();
            if (paymentType == Constants.UpgradeToMembershipPayment)
                iPaymentService = new UpgradeToMembershipPayment();
            if (paymentType == Constants.VideoPayment)
                iPaymentService = new VideoPayment();

            return iPaymentService;
        }
    }
}
