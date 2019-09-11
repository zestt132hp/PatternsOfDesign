using PatternsOfDesign.generative_patterns.AbstractFactory.DesignElement;

namespace PatternsOfDesign.generative_patterns.AbstractFactory
{
    interface IGuiElement
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
    }
}
