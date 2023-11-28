public class HttpCookie
{
    private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();

    public string this[string key]
    {
        get
        {
            return _dictionary[key];
        }
        set
        {
            _dictionary[key] = value;
        }

    }
}
class Program
{
    static void Main(string[] args)
    {
        
        var httpCookie = new HttpCookie();
        httpCookie["name"] = "Mosh";
        Console.WriteLine(httpCookie["name"]);
        

    }
    static void UseProperty()
    {
        var pr = new Person();
        pr.Birthdate = new DateTime(1999, 11, 19);
        Console.WriteLine(pr.Age);
    }
    static void UseCase()
    {
        var customer = new Customer(1);
        customer.Orders.Add(new Order());
        customer.Orders.Add(new Order());

        customer.Promote();

        Console.WriteLine(customer.Orders.Count);
    }
}
