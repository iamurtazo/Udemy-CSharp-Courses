public class PhotoProcessor
{
    public delegate void PhotoFilterHandler(Photo photo);

    public void Process(string path)
    {
        var photo = Photo.Load(path);

        var filters = new PhotoFilters();
        filters.ApplyBrightness(photo);
        filters.ApplyContrast(photo);
        filters.Resize(photo);

        photo.Save();
    }

}