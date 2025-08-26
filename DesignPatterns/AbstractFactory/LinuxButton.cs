namespace AbstractFactory
{
    internal class LinuxButton : Button
    {
        public void Paint()
        {
            Console.WriteLine("You have created LinuxButton.");
        }
    }
}
