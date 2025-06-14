namespace CommandPattern.CeilingFan
{
    public class CeilingFan
    {
        private string location;
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;
        private int speed;
        public CeilingFan(string location)
        {
            this.location = location;
            speed = OFF;
        }

        public void High()
        {
            speed = HIGH;
            Console.WriteLine(location + " ceiling fan is on high");
        }

        public void Medium()
        {
            speed = MEDIUM;
        }

        public void Low()
        {
            speed = LOW;
            Console.WriteLine(location + " ceiling fan is on low");
        }

        public void Off()
        {
            speed = OFF;
            Console.WriteLine(location + " ceiling fan is off");
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}
