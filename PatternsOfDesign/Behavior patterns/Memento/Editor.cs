
namespace PatternsOfDesign.Behavior_patterns.Memento
{
    class Editor
    {
        private int _x,_y, _selectionWidth;
        private string _text;

        public void SetText(string text)
        {
            _text = text;
        }

        public void SetPointPosition(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void SetSelectionWidth(int width)
        {
            _selectionWidth = width;
        }

        public Snapshot CreateSnapshot()
        {
            return new Snapshot(this);
        }

        internal class Snapshot
        {
            private readonly Editor _editor;
            private readonly int _x;
            private readonly int _y;
            private readonly int _selectionWidth;
            private readonly string _text;
            public Snapshot(Editor editor)
            {
                _editor = editor;
                _x = editor._x;
                _y = editor._y;
                _text = editor._text;
                _selectionWidth = editor._selectionWidth;
            }

            public Editor Restore()
            {
                _editor.SetPointPosition(_x, _y);
                _editor.SetSelectionWidth(_selectionWidth);
                _editor.SetText(_text);
                return _editor;
            }
        }
    }
}
