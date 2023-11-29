public class PresentationObject
{
    public int Width { get; set; }
    public int Height { get; set; }

    public void Copy()
    {
        Console.WriteLine("Item is copied");
    }
    public void Duplicate()
    {
        Console.WriteLine("Item is duplicated");
    }

}