namespace PatternsOfDesign.Behavior_patterns.Memento
{
    class Command
    {
        private Editor.Snapshot _backup;

        public void MadeBackup(Editor editor)
        {
            _backup = editor.CreateSnapshot();
        }

        public void Undo()
        {
            _backup?.Restore();
        }
    }
}
