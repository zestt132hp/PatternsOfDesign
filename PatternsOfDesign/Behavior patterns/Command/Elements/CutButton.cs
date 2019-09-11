using System;
namespace PatternsOfDesign.Behavior_patterns.Command.Elements
{
    class CutButton
    {
        public void SetCommand(Action execute)
        {
            execute.Invoke();
        }
    }
}
