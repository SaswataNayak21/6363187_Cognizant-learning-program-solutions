using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotifier notifier = new EmailNotifier();

            notifier = new SMSNotifierDecorator(notifier);
            notifier = new SlackNotifierDecorator(notifier);

            notifier.Send("System Maintenance at 10 PM");
        }
    }
}
