using BusinessRuleProcessor;
using BusinsessConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessRuleEngineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int paymentType = -1;
            bool validOption = false;
            string paymentOption = string.Empty;

            //Print payment options in console
            foreach (var key in Constants.DictPaymentMethods.Keys)
            {
                Console.WriteLine(key + "." + Constants.DictPaymentMethods[key]);
            }

            //Accept valid user input.
            do
            {
                Console.WriteLine("\nChoose a Payment Type Number listed above and press any Enter");
                paymentOption = Console.ReadLine();
                int.TryParse(paymentOption, out paymentType);
                if (string.IsNullOrWhiteSpace(paymentOption))
                {
                    validOption = false;
                }
                else
                {
                    if (Constants.DictPaymentMethods.ContainsKey(paymentType))
                    {
                        validOption = true;
                    }
                }

            } while (validOption == false);

            Console.WriteLine("\nPlease wait while processing payment option : " + Constants.DictPaymentMethods[paymentType] + "\n");
            IPaymentService iPaymentService = PaymentFactory.GetPaymentType(Constants.DictPaymentMethods[paymentType]);
            string message = iPaymentService.ProcessPaymenRequest();
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
