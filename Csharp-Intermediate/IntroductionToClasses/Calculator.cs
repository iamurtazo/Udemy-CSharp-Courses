class Calculator
{
    public void Add(params int[] nums)
    {
        int sum = 0;
        foreach(var num in nums)
            sum += num;
        Console.WriteLine(sum);
    }
}

