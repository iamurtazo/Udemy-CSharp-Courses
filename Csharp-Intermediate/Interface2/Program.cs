// See https://aka.ms/new-console-template for more information
using System.Net.Mail;
using System.Reflection.Metadata;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var notificationChannels = new List<INotificationChannel>();
        notificationChannels.Add(new MailNotificationChannel());
        notificationChannels.Add(new SmsNotificationChannel());
        
        var encoder = new VideoEncoder();

        foreach(var item in notificationChannels)
        {
            encoder.Encode(item);
        }
        
        //encoder.RegisterNotificationChannel(new SmsNotificationChannel());
        //encoder.RegisterNotificationChannel(new MailNotificationChannel());
        
        
    }
}
