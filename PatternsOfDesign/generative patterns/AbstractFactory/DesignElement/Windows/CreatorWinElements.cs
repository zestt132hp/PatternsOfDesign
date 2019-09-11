namespace PatternsOfDesign.generative_patterns.AbstractFactory.DesignElement.Windows
{
    class CreatorWinElements:IGuiElement
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WinCheckBox();
        }
    }
}
