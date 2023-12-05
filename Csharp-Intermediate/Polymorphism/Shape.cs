public class Circle : Shape // workflowobject
{
    public override void Draw()
    {
        Console.WriteLine("Draw a circle");
    }
}
public class Rectangle : Shape // workflowobject
{
    public override void Draw()
    {
        Console.WriteLine("Draw a rectangle");
    }
}
public class Triangle : Shape // workflowobject
{
    public override void Draw()
    {
        Console.WriteLine("Draw a triangle");
    }
}
public class Shape //Workflow
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Position Position { get; set; }

    public virtual void Draw()
    {

    }
    
}
