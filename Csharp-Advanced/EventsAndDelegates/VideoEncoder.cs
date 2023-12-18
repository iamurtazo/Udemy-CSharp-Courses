using System.Threading;
public class VideoEncoder
{
    // 1st define a delegate
    //public delegate void VideoEncodedEventHandler(object source, EventArgs args);

    // 2nd define an event based on that delegate
    public event EventHandler<VideoEventArgs> VideoEncoded;

    // 3rd rasie an event

    public void Encode(Video video)
    {
        Console.WriteLine("Encoding the video");
        Thread.Sleep(3000);
        OnVideoEncoded(video);
    }

    // raising an event
    protected virtual void OnVideoEncoded(Video video)
    {
        if(VideoEncoded != null)
            VideoEncoded(this, new VideoEventArgs() {Video = video}); 
    }
}

public class VideoEventArgs : EventArgs
{
    public Video Video { get; set; }
}