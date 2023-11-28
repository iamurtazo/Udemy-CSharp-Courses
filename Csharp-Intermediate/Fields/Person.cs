public class Person
{
    private string _name;
    public DateTime Birthdate {get; set;}
    public int Age
    {
        get
        {
            var timeSpan = DateTime.Today - Birthdate;
            var years = timeSpan.Days/365;
            return years;
        }
        
    }


    public void SetName(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
            Console.WriteLine("can not be null");
        this._name = name;
    }

}