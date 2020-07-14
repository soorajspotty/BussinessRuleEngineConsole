using BusinessRuleProcessor;
using BusinsessConstants;
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
            iPaymentService = PaymentFactory.GetPaymentType(Constants.PhysicalProductPayment);
            //Act
            string message = iPaymentService.ProcessPaymenRequest();
            //Assret
            Assert.AreEqual(message, Constants.PhysicalProductPaymentSuccessMessage);
        }

        [Test]
        public void Process_BookPayment_Success()
        {
            //Arrange
            iPaymentService = PaymentFactory.GetPaymentType(Constants.BookPayment);
            //Act
            string message = iPaymentService.ProcessPaymenRequest();
            //Assret
            Assert.AreEqual(message, Constants.BookPaymentSuccessMessage);
        }

        [Test]
        public void Process_Membership_Success()
        {
            //Arrange
            iPaymentService = PaymentFactory.GetPaymentType(Constants.MembershipPayment);
            //Act
            string message = iPaymentService.ProcessPaymenRequest();
            //Assret
            Assert.AreEqual(message, Constants.MembershipPaymentSuccessMessage);
        }

        [Test]
        public void Process_UpgradeMembership_Success()
        {
            //Arrange
            iPaymentService = PaymentFactory.GetPaymentType(Constants.UpgradeToMembershipPayment);
            //Act
            string message = iPaymentService.ProcessPaymenRequest();
            //Assret
            Assert.AreEqual(message, Constants.UpgradeToMembershipPaymentSuccessMessage);
        }

    }
}
