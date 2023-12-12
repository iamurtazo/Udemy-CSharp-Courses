using System.Collections;
using System.Collections.Concurrent;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

partial class Program
{
    // where T: IComparable => constraint to interface
    // where T: Product => constraint to class, or any subclass
    // where T: struct => constraint to value type
    // where T: class => constraint to reference type
    // where T: new() => constraint to object that has default contructor
    static void Main(string[] args)
    {
        // Generics
        /* var digits = new GenericList<string>();
        digits.Add("C# Advanced");
        digits.Add(new string("Alabama"));

        var book = new GenericList<Book>();
        book.Add(new Book());

        var genericDictionary = new GenericDictionary<string, Book>();
        genericDictionary.Add("1928", new Book());
        //Console.WriteLine(genericDictionary.GetHashCode());

        var utilities = new Utilities<int>();
        Console.WriteLine("Utilities: " + utilities.Max(506, 067)); */

        var number = new Nullable<int>();
        var anotherNum = new Nullable<int>(5);

        Console.WriteLine($"Has Value: {number.HasValue}");
        Console.WriteLine($"Value: {number.GetValueOrDefault()}");

        Console.WriteLine($"Has Value: {anotherNum.HasValue}");
        Console.WriteLine($"Value: {anotherNum.GetValueOrDefault()}");




    }
}
