using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample
{
    public class PayPalGateway
    {
        public void MakePayment(string user, double money)
        {
            Console.WriteLine($"[PayPal] Payment of ${money} made by {user}");
        }
    }

}
