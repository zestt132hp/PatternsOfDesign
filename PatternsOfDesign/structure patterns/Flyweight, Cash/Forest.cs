using System.Collections.Generic;

namespace PatternsOfDesign.structure_patterns
{
    class Forest
    {
        private readonly List<Tree> _trees;

        public Forest()
        {
            _trees = new List<Tree>();
        }

        public void PlantTree(int x, int y, string color, string name, string texture)
        {
            var type = TreeFactory.GetTreeType(name, color, texture);
            var tree = new Tree(x, y , type);
            _trees.Add(tree);
        }

        public void Draw(object canvas)
        {
            foreach (var tree in _trees)
            {
                tree.Draw(canvas);
            }
        }
    }
}
