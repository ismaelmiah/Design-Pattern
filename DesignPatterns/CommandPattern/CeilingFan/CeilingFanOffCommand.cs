namespace CommandPattern.CeilingFan
{
    public class CeilingFanOffCommand : ICommand
    {
        private CeilingFan ceilingFan;
        private int previousSpeed;
        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            previousSpeed = ceilingFan.GetSpeed();
            ceilingFan.Off();
        }
        public void Undo()
        {
            switch (previousSpeed)
            {
                case CeilingFan.HIGH:
                    ceilingFan.High();
                    break;
                case CeilingFan.MEDIUM:
                    ceilingFan.Medium();
                    break;
                case CeilingFan.LOW:
                    ceilingFan.Low();
                    break;
                case CeilingFan.OFF:
                    ceilingFan.Off();
                    break;
            }
        }
    }
}
