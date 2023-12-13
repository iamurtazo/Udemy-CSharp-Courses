public class Program
{
    static void Main(string[] args)
    {
        // lambda expression layout 
        // args => expression
        Func<int, int> square = number => number * number;

        Console.WriteLine(square(9));
        // lambda expression has access to argument which passed and variables inside a method where it is declared

        const int factor = 5;
        Func<int, int> multiplier = n => n * factor;


        Console.WriteLine(multiplier(306));

        var bookCollection = new BookRepository().GetBooks();
        var targetBook = bookCollection.FindAll(book => book.Price < 65);

        foreach(var book in targetBook)
        {
            Console.WriteLine("Title: " + book.Title + " " + book.Price + "$.");
        }


    }
    
}
//startbootstrap.com/template/sb-admin
