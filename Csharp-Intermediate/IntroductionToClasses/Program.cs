class Program
{
    static void Main(string[] args)
    {
        int num;
        bool isCon = int.TryParse("12", out num);
        if(isCon) Console.WriteLine("success: " + num);
        else Console.WriteLine("failed");
        //UsePoint();
        //UsePrams();
    }
    static void UseParams()
    {
        var calc = new Calculator();
        Console.WriteLine(calc.Add(1));
        Console.WriteLine(calc.Add(1, 2));
        Console.WriteLine(calc.Add(1, 2, 3));
        Console.WriteLine(calc.Add(1, 2, 3, 4));
        Console.WriteLine(calc.Add([1, 2, 3, 4, 5]));

    }
    static void UsePoint()
    {
        try
        {
            var pnt = new Point(5, 8);
            pnt.Move(1, 4);
            Console.WriteLine(pnt.X + " " + pnt.Y);

            pnt.Move(new Point(34, 45));
            Console.WriteLine(pnt.X + " " + pnt.Y);

            pnt.Move(null);
            Console.WriteLine(pnt.X + " " + pnt.Y);
        }
        catch (Exception)
        {
            Console.WriteLine("Error occured");
        }
    }
}

