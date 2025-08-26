namespace AbstractFactory
{
    internal class WinFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new WinButton();
        }

        public Checkbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }



}
