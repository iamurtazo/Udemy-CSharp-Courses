// See https://aka.ms/new-console-template for more information
public class Message
{
    private readonly INotificationChannel _notificationChannel;

    public Message(INotificationChannel notificationChannel)
    {
        this._notificationChannel = notificationChannel;
    }
    
}