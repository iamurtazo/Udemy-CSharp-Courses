public class BookRepository
{
    public IEnumerable<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book() { Title = "ADO.NET Step by Step", Price = 5f},
            new Book() { Title = "C#10 and .NET6", Price = 56f},
            new Book() { Title = "Grokking Algorihms", Price = 30f},
            new Book() { Title = "Men", Price = 25f},
            new Book() { Title = "TTMIK 4", Price = 23f},
            new Book() { Title = "C# Advanced Topics", Price = 50f}
        };


    }
    
}