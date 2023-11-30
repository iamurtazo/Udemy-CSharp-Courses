//namespace Csharp-Intermediate
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
    
