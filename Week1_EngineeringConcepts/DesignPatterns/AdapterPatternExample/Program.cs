namespace AdapterPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer player = new AudioPlayer();

            player.Play("mp3", "song.mp3");
            player.Play("mp4", "movie.mp4");
            player.Play("vlc", "video.vlc");
            player.Play("avi", "movie.avi");
        }
    }
}
