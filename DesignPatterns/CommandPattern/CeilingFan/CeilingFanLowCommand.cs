namespace CommandPattern.CeilingFan
{
    public class CeilingFanLowCommand : ICommand
    {
        private CeilingFan ceilingFan;
        private int previousSpeed;
        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            previousSpeed = ceilingFan.GetSpeed();
            ceilingFan.Low();
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
