namespace AdapterPatternExample
{
    public class VlcPlayer : AdvancedMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Playing vlc file: " + fileName);
        }

        public void PlayMp4(string fileName)
        {
        }
    }
}