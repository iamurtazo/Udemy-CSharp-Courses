// See https://aka.ms/new-console-template for more information
public class MailNotificationChannel : INotificationChannel
{
    public void Send()
    {
        Console.WriteLine("Sending email");
    }
}