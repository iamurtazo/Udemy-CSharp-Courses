// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        var dbMigrator = new DbMigrator(new FileLogger("C:/Users/iammu/log.txt"));
        dbMigrator.Migrate();
        
    }
}
