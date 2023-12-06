// See https://aka.ms/new-console-template for more information
public class DbMigrator
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


}
