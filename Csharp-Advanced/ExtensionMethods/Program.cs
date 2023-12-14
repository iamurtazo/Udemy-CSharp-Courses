static class Program
{
    static void Main(string[] args)
    {
        string post = "This is a very long post that gonna include only a few words)) haha joke";
        Console.WriteLine(post.Shorten(1));

        var nums = new List<int>{1, 2, 3, 4, 5};
        var r = nums.RemoveLastElement();
        Console.WriteLine("After removing: " + String.Join(",", r));

        var text = "Advanced";
        Console.WriteLine("After doubling: " + text.DoubleIt());

        IEnumerable<int> numbers = new List<int>(){5, 78, 9};
        Console.WriteLine(numbers.Max());
        
    }   
    
}
