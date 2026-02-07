using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern2
{
    public class EmailSender : INotificationSender
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"[EMAIL] To: {to} | Message: {message}");
        }
    }
}
