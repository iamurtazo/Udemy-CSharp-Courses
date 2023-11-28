class Program
{
    static void Main(string[] args)
    {
        //UseIndexers();
        //UseProperty();
        //UseCase();
    }
    static void UseIndexers()
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
