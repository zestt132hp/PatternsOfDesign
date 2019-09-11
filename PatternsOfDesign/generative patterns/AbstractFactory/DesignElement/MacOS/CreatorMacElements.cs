using PatternsOfDesign.generative_patterns.AbstractFactory.DesignElement.Windows;

namespace PatternsOfDesign.generative_patterns.AbstractFactory.DesignElement.MacOS
{
    class CreatorMacElements:IGuiElement
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WinCheckBox();
        }
    }
}
