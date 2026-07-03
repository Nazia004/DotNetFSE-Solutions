namespace RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();

            ICommand lightOn = new LightOnCommand(light);
            ICommand lightOff = new LightOffCommand(light);

            Remote remote = new Remote();

            remote.SetCommand(lightOn);
            remote.PressButton();

            remote.SetCommand(lightOff);
            remote.PressButton();
        }
    }
}
