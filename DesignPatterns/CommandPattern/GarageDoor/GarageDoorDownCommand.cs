namespace CommandPattern.GarageDoor
{
    public class GarageDoorDownCommand : ICommand
    {
        private GarageDoor garageDoor;
        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.Down();
        }
        public void Undo()
        {
            garageDoor.Up();
        }
    }
}
