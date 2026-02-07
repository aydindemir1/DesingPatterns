using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern2
{
    public abstract class NotificationService
    {
        // Factory Method
        protected abstract INotificationSender CreateSender();

        public void Notify(string to, string message)
        {
            // Sabit akış (template gibi): validation + sender creation + send
            if (string.IsNullOrWhiteSpace(to))
                throw new ArgumentException("Recipient cannot be empty.");

            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("Message cannot be empty.");

            var sender = CreateSender();
            sender.Send(to, message);
        }
    }

}
