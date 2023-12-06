// See https://aka.ms/new-console-template for more information
public class FileLogger : ILogger
{
    private readonly string _path;
    public FileLogger(string path)
    {
        _path = path;
    }
    public void LogInfo(string message)
    {
        Log(message, "info");
    }
    public void LogError(string message)
    {
        Log(message, "error");
    }
    public void Log(string message, string messageType)
    {
        using (var streamWriter = new StreamWriter(_path, true))
        {
            streamWriter.WriteLine(messageType + ": " + message);
        }
    }
}
