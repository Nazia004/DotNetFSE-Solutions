namespace AdapterPatternExample
{
    public class Mp4Player : AdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing mp4 file: " + fileName);
        }

        public void PlayVlc(string fileName)
        {
        }
    }
}