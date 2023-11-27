class Program
{
    static void Main(string[] args)
    {
        var pr = new Person();
        pr.Birthdate = new DateTime(1999, 12, 19);
        Console.WriteLine(pr.Birthdate);

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
