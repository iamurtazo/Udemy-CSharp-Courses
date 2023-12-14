using System.Security.Cryptography;

class Program
{
    public delegate void ConsoleLogger(string msg);
    static void Main(string[] args)
    {
        //ConsoleLogger consoleLogger = (string msg) => Console.WriteLine(msg);
        ConsoleLogger consoleLogger = ConsoleLog;
        consoleLogger("Murtazo");

    }
    static void ConsoleLog(string msg)
    {
        Console.WriteLine("Message says: " + msg);
    }
   
    
}