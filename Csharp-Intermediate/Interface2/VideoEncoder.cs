// See https://aka.ms/new-console-template for more information
public class VideoEncoder
{
    private readonly MailService _mailService;
    public VideoEncoder()
    {
        _mailService = new MailService();
    }
    public void Encode(Video video)
    {
        _mailService.Send(new Mail());
    }
}
