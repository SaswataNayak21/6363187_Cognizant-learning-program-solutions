using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample
{
    public interface PaymentProcessor
    {
    void ProcessPayment(string customerName, double amount);
    }
}

