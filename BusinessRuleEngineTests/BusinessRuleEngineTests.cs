﻿using BusinessRuleProcessor;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineTests
{
    /// <summary>
    /// Class which includes test in a TDD development style.
    /// Used NUnit nuget package to facilitate unit testing
    /// </summary>
    [TestFixture]
    public class BusinessRuleEngineTests
    {
        IPaymentService iPaymentService;
        [Test]
        public void Process_PhycicalProductPayment_Success()
        {
            //Arrange
            iPaymentService = PaymentFactory.GetPaymentType("Physical Product Payment");
            //Act
            string message = iPaymentService.ProcessPaymenRequest();
            //Assret
            Assert.AreEqual(message, "Payment Successfull & Genererated a packaging slip for shipping");
        }
    }
}
