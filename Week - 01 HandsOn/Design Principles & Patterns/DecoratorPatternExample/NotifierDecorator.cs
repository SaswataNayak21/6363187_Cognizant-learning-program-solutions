using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    public abstract class NotifierDecorator : INotifier
    {
        protected INotifier _wrappee;

        public NotifierDecorator(INotifier notifier)
        {
            _wrappee = notifier;
        }

        public virtual void Send(string message)
        {
            _wrappee.Send(message);
        }
    }

}
