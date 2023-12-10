// See https://aka.ms/new-console-template for more information
public class VideoEncoder
{
    private readonly IList<INotificationChannel> _notificationChannnels;
    public VideoEncoder()
    {
        _notificationChannnels = new List<INotificationChannel>();
    }
    public void Encode()
    {
        foreach(var channel in _notificationChannnels)
        {
            channel.Send(new Message());
        }
    }
    public void RegisterNotificationChannel(INotificationChannel channel)
    {
        _notificationChannnels.Add(channel);
    }
}
