namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var configs = new List<string>
            {
                "Windows",
                "Mac",
                "Linux"
            };

            string os = configs[new Random().Next(0, configs.Count)];
            GUIFactory factory;
            if (os == "Windows")
            {
                factory = new WinFactory();
            }
            else if (os == "Mac")
            {
                factory = new MacFactory();
            }
            else
            {
                factory = new LinuxFactory();
            }

            Application app = new Application(factory);
            app.CreateUI();
            app.Paint();
        }
    }
}
