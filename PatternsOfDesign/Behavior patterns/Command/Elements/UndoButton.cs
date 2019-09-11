using System;

namespace PatternsOfDesign.Behavior_patterns.Command.Elements
{
    class UndoButton
    {
        public void SetCommand(Action execute)
        {
            execute.Invoke();
        }
    }
}
