using System.Diagnostics.Contracts;
using System.Xml.Serialization;

public class DBMigrator
{
    private readonly Logger _logger;

    public DBMigrator(Logger logger)
    {
        this._logger = logger;
    }
    public void Migrate()
    {
        _logger.Log("Is being migrated");
    }
}
