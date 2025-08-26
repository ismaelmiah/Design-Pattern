namespace AbstractFactory
{
    internal class MacFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new MacButton();
        }
        public Checkbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }



}
