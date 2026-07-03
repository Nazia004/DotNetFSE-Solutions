namespace AdapterPatternExample
{
    public class AudioPlayer : MediaPlayer
    {
        private MediaAdapter mediaAdapter;

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("mp3"))
            {
                Console.WriteLine("Playing mp3 file: " + fileName);
            }
            else if (audioType.Equals("vlc") || audioType.Equals("mp4"))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media format.");
            }
        }
    }
}