// See https://aka.ms/new-console-template for more information
public class VideoEncoder
{
    private readonly IList<INotificationChannel> _notificationChannnels;
    public VideoEncoder()
    {
        _notificationChannnels = new List<INotificationChannel>();
    }
    public void Encode(INotificationChannel channel)
    {
            channel.Send();    
    }

}
