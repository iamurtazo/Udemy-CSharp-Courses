using System.Runtime.InteropServices;
using System.Security.Cryptography;
class Program
{
    public delegate void ConsoleLogger(string msg);
    
    static void Main(string[] args)
    {
        //ConsoleLogger consoleLogger = (string msg) => Console.WriteLine(msg);
        //ConsoleLogger consoleLogger = ConsoleLog;
        //consoleLogger("Murtazo");

        //string matn = "murtazo toshniyozov this is going to be a very long .... in your life";
        //Shortener(matn, 5);

        var video = new Video(){ Title = "Video 1" };
        var videoEncoder = new VideoEncoder();
        var mailService = new MailService();
        var messageService = new MessageService();


        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;;
        videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
        videoEncoder.Encode(video);

    }
    public static void Shortener(string text, int number)
    {
        if (number < 0)
            throw new InvalidOperationException("Number should be greater or equal to zero");
        if (number == 0)
            Console.WriteLine("");

        
        var splittedText = text.Split(" ");
        var listOfWords = new List<string>(){};
        int i = 0;
        while(i != number)
        {
            listOfWords.Add(splittedText[i]);
            i++;
        }

        Console.Write(string.Join(" ", listOfWords)); Console.WriteLine("...");

        Index i1 = new (value: 3);
    }
    static void ConsoleLog(string msg)
    {
        Console.WriteLine("Message says: " + msg);
    }
    
    
}
