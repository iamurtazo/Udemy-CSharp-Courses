
public class Point
{
    public int X;
    public int Y;

    public Point(int x, int Y)
    {
        this.X = x;
        this.Y = Y;
    }

    public void Move(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
    public void Move(Point newLocation)
    {
        if (newLocation == null)
            throw new ArgumentNullException("newLocation");
        Move(newLocation.X, newLocation.Y);
    }
}

