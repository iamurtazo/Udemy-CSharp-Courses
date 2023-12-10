// See https://aka.ms/new-console-template for more information
using System.Net.Mail;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        var encoder = new VideoEncoder();
        encoder.RegisterNotificationChannel(new SmsNotificationChannel());
        encoder.Encode();
        
    }
}
