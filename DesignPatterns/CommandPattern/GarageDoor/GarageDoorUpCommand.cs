namespace CommandPattern.GarageDoor
{
    public class GarageDoorUpCommand : ICommand
    {
        private GarageDoor garageDoor;
        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.Up();
        }
        public void Undo()
        {
            garageDoor.Down();
        }
    }
}
