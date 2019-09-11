
namespace PatternsOfDesign.Behavior_patterns.Command.Commands
{
    abstract class Command
    {
        protected readonly Editor Editor;
        protected readonly ApplicationCommand App;
        private string _backup;

        protected Command(Editor editor, ApplicationCommand app)
        {
            Editor = editor;
            App = app;
        }

        public virtual void SaveBackup()
        {
            _backup = Editor.Text;
        }

        public virtual void Undo()
        {
            Editor.Text = _backup;
        }
        public abstract bool Execute();
    }
}
