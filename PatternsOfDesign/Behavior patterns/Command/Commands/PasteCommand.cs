
namespace PatternsOfDesign.Behavior_patterns.Command.Commands
{
    class PasteCommand:Command
    {
        public string RegexText { get; set; }

        public override bool Execute()
        {
            SaveBackup();
            Editor.ReplaceSelection(App.Clipboard);
            return true;
        }

        public PasteCommand(Editor editor, ApplicationCommand app) : base(editor, app)
        {
        }

        public PasteCommand(Editor editor, ApplicationCommand app, string regexText) : base(editor, app)
        {
            RegexText = regexText;
        }
    }
}
