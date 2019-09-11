namespace PatternsOfDesign.structure_patterns
{
    class TreeType
    {
        private readonly string _name;
        private readonly string _color;
        private readonly string _texture;

        public virtual void Draw(object canvas, int x, int y)
        {

        }

        public string Name => _name;
        public string Color => _color;
        public string Texture => _texture;

        public TreeType(string name, string color, string texture)
        {
            _name = name;
            _color = color;
            _texture = texture;
        }
    }
}
