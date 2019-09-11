using System;

namespace PatternsOfDesign.Behavior_patterns.Command.Elements
{
    class CopyButton
    {
        public void SetCommand(Action d)
        {
            d.Invoke();
        }
    }
}
