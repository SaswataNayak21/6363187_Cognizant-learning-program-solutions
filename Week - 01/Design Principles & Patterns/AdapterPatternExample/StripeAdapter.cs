using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample
{
    public class StripeAdapter : PaymentProcessor
    {
        private readonly StripeGateway _stripe;

        public StripeAdapter(StripeGateway stripe)
        {
            _stripe = stripe;
        }

        public void ProcessPayment(string customerName, double amount)
        {
            _stripe.ExecuteTransaction(customerName, amount);
        }
    }

}
