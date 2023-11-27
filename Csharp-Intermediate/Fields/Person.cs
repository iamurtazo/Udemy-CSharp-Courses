public class Person
{
    private string _name;
    private int age;
    private DateTime _birthDdate;

    public DateTime Birthdate
    {
        get {return _birthDdate;}
        set {_birthDdate = value;}
    }

    public void SetName(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
            Console.WriteLine("can not be null");
        this._name = name;
    }

}