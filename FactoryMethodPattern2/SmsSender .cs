using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern2
{
    public class SmsSender : INotificationSender
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"[SMS] To: {to} | Message: {message}");
        }
    }
}
