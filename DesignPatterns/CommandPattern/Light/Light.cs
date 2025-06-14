namespace CommandPattern.Light
{
    public class Light
    {
        private string location;
        public Light(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine($"{location} Light is On");
        }
        public void Off()
        {
            Console.WriteLine($"{location} Light is Off");
        }
    }


}
