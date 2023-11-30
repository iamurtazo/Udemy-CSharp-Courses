//namespace Csharp-Intermediate
using System;
class Program
{
    static void Main(string[] args)
    {
        Text text = new Text();
        Shape shape = text;
        Console.WriteLine(shape.GetType());
        
        //var car = new Car("D 654 XA");
        //Amazon.CalculateRating();
    }
    /* static void UseProtected()
    {
        // access modifiers
        var customer = new Customer();
        customer.Name = "Uncle Bob";
        customer.Id = 3;
        customer.Promote();
    } */
}
    
