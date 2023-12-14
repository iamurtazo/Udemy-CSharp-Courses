class Program
{
    static void Main(string[] args)
    {
        string post = "This is a very long post that gonna include only a few words)) haha joke";
        Console.WriteLine(post.Shorten(5));

    }   
}
public static class StringExtension
{
    public static string Shorten(this String text, int num)
    {
        if (num < 0)
            throw new InvalidOperationException("Number should be greater than 0;");
        if (num == 0)
            return "";
        var textSplitted = text.Split(" ");

        return string.Join(" ", textSplitted.Take(num));
    }
}