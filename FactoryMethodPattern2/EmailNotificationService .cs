using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern2
{
    public class EmailNotificationService : NotificationService
    {
        protected override INotificationSender CreateSender()
            => new EmailSender();
    }
}
