namespace AdapterPatternExample
{
    public class MediaAdapter : MediaPlayer
    {
        private AdvancedMediaPlayer advancedPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.Equals("vlc"))
            {
                advancedPlayer = new VlcPlayer();
            }
            else if (audioType.Equals("mp4"))
            {
                advancedPlayer = new Mp4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc"))
            {
                advancedPlayer.PlayVlc(fileName);
            }
            else if (audioType.Equals("mp4"))
            {
                advancedPlayer.PlayMp4(fileName);
            }
        }
    }
}