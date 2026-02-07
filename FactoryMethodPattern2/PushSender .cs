using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern2
{
    public class PushSender : INotificationSender
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"[PUSH] To: {to} | Message: {message}");
        }
    }
}
