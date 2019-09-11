using System.Linq;

namespace PatternsOfDesign.structure_patterns
{
    class TreeFactory
    {
        private static readonly TreeType[] _treeTypes;

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            if (_treeTypes != null && _treeTypes.Length > 0)
            {
                return _treeTypes
                    .FirstOrDefault(x => x.Name == name && x.Texture == texture && x.Color == color);
            }
            else
            {
                TreeType tree = new TreeType(name, color, texture);
                _treeTypes?.SetValue(tree, _treeTypes.Length - 1);
                return tree;
            }
        }
    }
}
