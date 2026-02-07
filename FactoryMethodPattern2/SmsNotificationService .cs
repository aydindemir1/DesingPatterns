using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern2
{
    public class SmsNotificationService : NotificationService
    {
        protected override INotificationSender CreateSender()
            => new SmsSender();
    }
}
