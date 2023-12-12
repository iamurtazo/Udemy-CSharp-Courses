public class Program
{
    static void Main(string[] args)
    {
        var processor = new PhotoProcessor();

        var filters = new PhotoFilters();

        PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;

        filterHandler += filters.ApplyBrightness;
        filterHandler += RemoveRedEyeFilter;
        processor.Process("photo.jpg", filterHandler);

        
    }
    static void RemoveRedEyeFilter(Photo photo)
    {
        Console.WriteLine("Apply RemoveRedEye");
    }
}
