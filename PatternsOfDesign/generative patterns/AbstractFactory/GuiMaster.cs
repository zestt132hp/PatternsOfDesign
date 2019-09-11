using PatternsOfDesign.generative_patterns.AbstractFactory.DesignElement;

namespace PatternsOfDesign.generative_patterns.AbstractFactory
{
    class GuiMaster
    {
        private IGuiElement _gui;
        private ICheckBox _checkBox;
        private IButton _button;
        public GuiMaster(IGuiElement gui)
        {
            _gui = gui;
        }

        public void CreateElements()
        {
            _button = _gui.CreateButton();
            _checkBox = _gui.CreateCheckBox();
        }

        public void Paint()
        {
            _button.Paint();
            _checkBox.Paint();
        }
    }
}
