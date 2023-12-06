// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        var dbMigrator = new DbMigrator();
        
    }
}

public class DbMigrator : ILogger
{
    private readonly ILogger _logger;

    public DbMigrator(ILogger logger)
    {
        this._logger = logger;
    }

    public void Migrate()
    {
        _logger.LogInfo("Migration started at {0}" + DateTime.Now);
        _logger.LogInfo("Migration finished at {0}" + DateTime.Now);
       
    }


    public void LogError(string message)
    {
        throw new NotImplementedException();
    }

}
