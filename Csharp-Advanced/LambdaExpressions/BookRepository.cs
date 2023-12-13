using System.Reflection;

public class BookRepository
{
    public List<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book() { Title = "C# Beginner", Price = 5 },
            new Book() { Title = "C# Advanced ", Price = 65 },
            new Book() { Title = "C# Intermediate", Price = 56 }
        };
    }
    
}
