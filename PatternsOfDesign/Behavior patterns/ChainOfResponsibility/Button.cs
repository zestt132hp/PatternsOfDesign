
using System;

namespace PatternsOfDesign.Behavior_patterns.ChainOfResponsibility
{
    class Button:Component
    {
        private readonly string _toolTypeText;
        public Button(string toolTypeText) : base(toolTypeText)
        {
            _toolTypeText = toolTypeText;
        }

        public override void ShowHelp()
        {
            Console.WriteLine(_toolTypeText);
        }
    }
}
