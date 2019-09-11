using System;

namespace PatternsOfDesign.Behavior_patterns.ChainOfResponsibility
{
    class Component:IComponentWithContextualHelp
    {
        public Container Container { get; set; }
        private readonly string _toolTypeText;

        public Component(string toolTypeText)
        {
            _toolTypeText = toolTypeText;
        }


        public virtual void ShowHelp()
        {
            if (string.IsNullOrEmpty(_toolTypeText))
            {
                Container.ShowHelp();
            }
            else
            {
                Console.WriteLine(_toolTypeText);
            }
        }
    }
}
