//namespace Csharp-Intermediate
using System;
using System.IO;
enum Days
{
    Sunday,
    Monday,
    Tuesday, 
    Wednesday,
    Thursday,
    Friday, 
    Saturday
}

class Program
{
    static void Main(string[] args)
    {

        Days today = Days.Wednesday;

        var todayValue = (int)today;
        Console.WriteLine($"todayValue: {todayValue}, today: {today}");
    
        /* Shape shape = new Text();
        Text text = (Text) shape; */
        /* Text text = new Text();
        Shape shape = text;

        var birsonda = 56;
        //var path = @"C:/Users/iammu/c_problems/main.c";
        StreamReader reader = new StreamReader(new MemoryStream(birsonda));
        Console.WriteLine("reader: " + reader); */

        // places we use this kind of converson
        // * 

    
        //Console.WriteLine(shape.GetType());
        
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
    
