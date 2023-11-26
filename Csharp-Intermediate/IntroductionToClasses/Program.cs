class Program
{
    static void Main(string[] args)
    {
        var calc = new Calculator();
        Console.WriteLine(calc.Add(1));
        Console.WriteLine(calc.Add(1, 2));
        Console.WriteLine(calc.Add(1, 2, 3));
        Console.WriteLine(calc.Add(1, 2, 3, 4));
        Console.WriteLine(calc.Add([1, 2, 3, 4, 5]));
        //UsePoint();
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

