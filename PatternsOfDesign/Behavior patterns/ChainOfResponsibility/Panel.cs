
using System;

namespace PatternsOfDesign.Behavior_patterns.ChainOfResponsibility
{
    class Panel:Container
    {
        private readonly string _modalHelpText;
        public Panel(string helpText) : base(helpText)
        {
            _modalHelpText = helpText;
        }

        public override void ShowHelp()
        {
            if (string.IsNullOrEmpty(_modalHelpText))
            {
                base.ShowHelp();
            }
            else
            {
                Console.WriteLine(_modalHelpText);
            }
        }
    }
}
