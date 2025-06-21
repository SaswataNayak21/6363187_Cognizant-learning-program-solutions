using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample
{
    public class PayPalAdapter : PaymentProcessor
    {
        private readonly PayPalGateway _payPal;

        public PayPalAdapter(PayPalGateway payPal)
        {
            _payPal = payPal;
        }

        public void ProcessPayment(string customerName, double amount)
        {
            _payPal.MakePayment(customerName, amount);
        }
    }

}
