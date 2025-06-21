using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample
{
    public class StripeGateway
    {
        public void ExecuteTransaction(string client, double amount)
        {
            Console.WriteLine($"[Stripe] Transaction of ${amount} completed for {client}");
        }
    }

}
