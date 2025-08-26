namespace AbstractFactory
{
    internal class LinuxCheckbox : Checkbox
    {
        public void Paint()
        {
            Console.WriteLine("You have created LinuxCheckbox.");
        }
    }
}
