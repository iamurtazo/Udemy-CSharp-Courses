public class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine("Mailservice: sending an email");
    }
}
