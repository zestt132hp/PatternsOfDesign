using System;

namespace PatternsOfDesign.Behavior_patterns.Command.Elements
{
    class PasteButton
    {
        public void SetCommand(Action execute)
        {
            execute.Invoke();
        }
    }
}
