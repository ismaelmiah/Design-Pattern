namespace AbstractFactory
{
    internal class WinButton : Button
    {
        public void Paint()
        {
            Console.WriteLine("You have created WinButton.");
        }
    }
}
