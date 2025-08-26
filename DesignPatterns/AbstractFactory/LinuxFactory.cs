namespace AbstractFactory
{
    internal class LinuxFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new LinuxButton();
        }
        public Checkbox CreateCheckbox()
        {
            return new LinuxCheckbox();
        }
    }



}
