public class Program
{
    static void Main(string[] args)
    {
        var books = new BookRepository().GetBooks();
        var book = books.SingleOrDefault(b => b.Title == "TTMIK 45");

        Console.WriteLine("BOOK: " + book.Title.ToUpper());

        
    }
    static void useLINQ()
    {
        //LINQ
        //Language Integrated Query

        var books = new BookRepository().GetBooks();

        //LINQ Extension Methods
        Console.WriteLine("LINQ Extension Methods method of querying");
        var cheapBooks = books
                            .Where(b => b.Price < 45)
                            .OrderBy(b => b.Title)
                            .Select(b => b.Price);
        
        foreach(var book in cheapBooks)
            Console.WriteLine(string.Join(", ", book));

        //LINQ Query Operators

        var cheaperBooks = 
                from b in books
                where b.Price < 30
                orderby b.Title
                select b;
        
        Console.WriteLine("LINQ Query Operators method of querying");
        foreach(var book in cheaperBooks)
            Console.WriteLine(string.Join(", ", book.Title, book.Price));

        // Console.WriteLine("===========");
        // var kitoblar = books.OrderBy(b => b.Title);
        // foreach(var kitob in cheapBooks)
        //     Console.WriteLine(string.Join(", ", kitob.Title));
    }
}
