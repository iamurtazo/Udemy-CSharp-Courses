class Program
{
    static void Main(string[] args)
    {

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

