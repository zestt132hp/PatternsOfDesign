using System;

namespace PatternsOfDesign.Behavior_patterns.Command.Commands
{
    class CutCommand:Command
    {
        public string RegexText { get; set; }
        public override bool Execute()
        {
            base.SaveBackup();
            if (string.IsNullOrEmpty(RegexText))
            {
                throw new NullReferenceException(nameof(RegexText));
            }
            App.Clipboard = Editor.GetSelection(RegexText);
            return true;

        }

        public CutCommand(Editor editor, ApplicationCommand app) : base(editor, app)
        {
        }

        public CutCommand(Editor editor, ApplicationCommand app, string regexText) : base(editor, app)
        {
            RegexText = regexText;
        }
    }
}
