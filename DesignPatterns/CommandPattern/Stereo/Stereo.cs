namespace CommandPattern.Stereo
{
    public class Stereo
    {
        private string location;
        private string cd;
        private int volume;

        public Stereo(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine(location + " stereo is on");
        }

        public void Off()
        {
            Console.WriteLine(location + " stereo is off");
        }

        public void SetCD()
        {
            cd = "Some CD";
        }
        public void SetVolume(int volume)
        {
            this.volume = volume;
            Console.WriteLine(location + " stereo volume set to " + volume);
        }
    }
}
