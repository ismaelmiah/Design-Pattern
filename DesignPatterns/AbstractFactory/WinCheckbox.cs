namespace AbstractFactory
{
    internal class WinCheckbox : Checkbox
    {
        public void Paint()
        {
            Console.WriteLine("You have created WinCheckbox.");
        }
    }
}
