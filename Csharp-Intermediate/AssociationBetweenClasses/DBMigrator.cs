using System.Diagnostics.Contracts;
using System.Xml.Serialization;

public class DBMigrator
{
    private int myVar;
    public int MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }
    
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
