using System.Collections;

partial class Program
{
    static void Main(string[] args)
    {
        // Generics
        var digits = new GenericList<string>();
        digits.Add("C# Advanced");
        digits.Add(new string("Alabama"));

    }
}