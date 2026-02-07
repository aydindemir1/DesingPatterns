using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern2
{
    public interface INotificationSender
    {
        void Send(string to, string message);
    }

}
