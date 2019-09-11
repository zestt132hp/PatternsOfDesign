
namespace PatternsOfDesign.Behavior_patterns.Command.Commands
{
    class UndoCommand:Command
    {
        public override bool Execute()
        {
            App.Undo();
            return false;
        }

        public UndoCommand(Editor editor, ApplicationCommand app) : base(editor, app)
        {
        }
    }
}
