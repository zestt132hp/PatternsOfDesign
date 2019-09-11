using System;
using PatternsOfDesign.Behavior_patterns.Command.Commands;
using PatternsOfDesign.Behavior_patterns.Command.Elements;

namespace PatternsOfDesign.Behavior_patterns.Command
{
    class ApplicationCommand
    {
        private Editor[] _editors;
        private Editor _activeEditor;
        private CommandHistory _history;

        public ApplicationCommand(Editor[] editors, Editor activeEditor, CommandHistory history)
        {
            _editors = editors;
            _activeEditor = activeEditor;
            _history = history;
        }

        public string Clipboard { get; set; }

        public void CreateUi()
        {
            var copyButton = new CopyButton();
            copyButton.SetCommand(Execute(new CopyCommand(_activeEditor, this)));
            var cutButton = new CutButton();
            cutButton.SetCommand(Execute(new CutCommand(_activeEditor, this)));
            var pasteButton = new PasteButton();
            pasteButton.SetCommand(Execute(new PasteCommand(_activeEditor, this)));
            var undoButton = new UndoButton();
            undoButton.SetCommand(Execute(new UndoCommand(_activeEditor, this)));
        }

        public bool Undo()
        {
            var command = _history.Pop(_history.Count);
            if (command == null)
            {
                return false;
            }
            else
            {
                command.Undo();
                return true;
            }
        }

        public Action Execute(Commands.Command command)
        {
            if (command.Execute())
            {
                Action act = delegate
                {
                    _history.Push(command);
                };
                return act;
            }
            else
            {
                return delegate { Console.Write("Can't execute command");};
            }
        }
    }
}
