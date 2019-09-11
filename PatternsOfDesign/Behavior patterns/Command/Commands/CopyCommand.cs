
using System;

namespace PatternsOfDesign.Behavior_patterns.Command.Commands
{
    class CopyCommand:Command
    {
        public string RegexText { get; set; }
        public override bool Execute()
        {
            if (string.IsNullOrEmpty(RegexText))
            {
                throw new NullReferenceException(nameof(RegexText));
            }
            App.Clipboard = Editor.GetSelection(RegexText);
            return false;
        }

        public CopyCommand(Editor editor, ApplicationCommand app) : base(editor, app)
        {
        }
        public CopyCommand(Editor editor, ApplicationCommand app, string regexText) : base(editor, app)
        {
            RegexText = regexText;
        }
    }
}
