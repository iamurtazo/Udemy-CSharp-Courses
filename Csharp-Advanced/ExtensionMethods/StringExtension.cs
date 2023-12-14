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
