using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            PaymentProcessor payPalProcessor = new PayPalAdapter(new PayPalGateway());
            payPalProcessor.ProcessPayment("Saswata", 100.0);

           
            PaymentProcessor stripeProcessor = new StripeAdapter(new StripeGateway());
            stripeProcessor.ProcessPayment("Abhinav", 250.0);

       

            Console.ReadLine();
        }
    }
}
