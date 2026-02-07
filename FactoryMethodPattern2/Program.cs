// See https://aka.ms/new-console-template for more information
using FactoryMethodPattern2;

Console.WriteLine("Hello, World!");


Console.Write("Channel (Email/Sms/Push): ");
var channel = Console.ReadLine();

NotificationService service = channel switch
{
    "Email" => new EmailNotificationService(),
    "Sms" => new SmsNotificationService(),
    "Push" => new PushNotificationService(),
    _ => throw new ArgumentException("Unknown channel")
};

service.Notify("user@demo.com", "Your order has been shipped!");

Console.ReadLine();