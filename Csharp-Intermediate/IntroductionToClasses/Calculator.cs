public class Calculator
{
    public int Add(params int[] nums)
    {
        int sum = 0;
        foreach(var num in nums)
            sum += num;
        return sum;
    }
}

