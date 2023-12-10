// See https://aka.ms/new-console-template for more information
public class SmsNotificationChannel : INotificationChannel
{
    public void Send()
    {
        Console.WriteLine("Sending sms...");
    }
}