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

    }   
    public static List<int> RemoveLastElement(this List<int> arr)
    {
        arr.RemoveAt(arr.Count - 1);
        //var newArr = arr;
        //newArr.Remove(newArr[newArr.Count - 1]);
        return arr;
    }
    public static string DoubleIt(this String word)
    {
        return word+word;
    }
}
public static class StringExtension
{
    public static string Shorten(this String text, int num)
    {
        if (num < 0)
            throw new ArgumentOutOfRangeException("Number should be greater than 0;");
        if (num == 0)
            return "";

        var textSplitted = text.Split(" ");
        if (textSplitted.Length < num)
            return text;

        return string.Join(" ", textSplitted.Take(num)) + "...";
    }
}    
