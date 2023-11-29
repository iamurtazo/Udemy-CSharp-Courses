class Program
{
    static void Main(string[] args)
    {
        var logger = new Logger();
        logger.Log("i am batman");

        var dbMigrator = new DBMigrator(logger);
        var installer = new Installer(new Logger());

        dbMigrator.Migrate();
        installer.Install();
    }
    static void InheritanceExamples()
    {
        var obj = new PresentationObject();
        obj.Width = 5;
        obj.Height = 10;
        obj.Copy();
        obj.Duplicate();
        
        var txt = new Text();
        txt.AddHyperLink("https://instagram.com/cristiano_ronaldo.com");
        txt.Copy();
        txt.Height = 56;
    }
}
