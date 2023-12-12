using Microsoft.VisualBasic;

public class Program
{
    static void Main(string[] args)
    {

    }
}
public class PhotoProcessor
{
    public delegate void PhotoFilterHandler(Photo photo);

    public void Process(string path)
    {
        var photo = new Photo.Load(path);

        var filters = new PhotoFilters();
        filters = ApplyBrightness(photo);
        filters = ApplyContrast(photo);
        filters = Resize(photo);

        photo.Save();
    }

}

internal class PhotoFilters
{
    public PhotoFilters()
    {
    }
    public void Resize()
    {
        Console.WriteLine() 
    }

    public void ApplyContrast()
    {
        throw new NotImplementedException();
    }

    public void ApplyBrightness(Photo.Load photo)
    {
        throw new NotImplementedException();
    }
}

public class Photo
{
    public static Photo Load(string path)
    {
        return new Photo();
    }
    public void Save()
    {

    }
}