//namespace Csharp-Intermediate
using System;
class Program
{
    static void Main(string[] args)
    {
        var car = new Car("D 654 XA");

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
public class Vehicle 
{
    private string _registrationNumber;
    /* public Vehicle()
    {
    } */
    public Vehicle (string registrationNumber)
    {
        this._registrationNumber = registrationNumber;
        Console.WriteLine("Vehicle is initialized {0}", registrationNumber); 
    }
}

public class Car : Vehicle
{
    public Car(string registrationNumber) : base(registrationNumber)
    {
        Console.WriteLine("Car is initialized {0}", registrationNumber);
    }
}
    
