
using System.Runtime.CompilerServices;

namespace PatternsOfDesign.structure_patterns
{
    class Tree
    {
        private int _x, _y;
        private TreeType _treeType;

        public TreeType TreeType { get; set; }

        public Tree(int x, int y, TreeType type)
        {
            _x = x;
            _y = y;
            _treeType = type;
        }

        public void Draw(object canvas)
        {
            _treeType.Draw(canvas, _x, _y);
            //Draw point with reference canvas and coordinates x, y
        }
    }
}
