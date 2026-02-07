using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern2
{
    public class PushNotificationService : NotificationService
    {
        protected override INotificationSender CreateSender()
            => new PushSender();
    }
}
