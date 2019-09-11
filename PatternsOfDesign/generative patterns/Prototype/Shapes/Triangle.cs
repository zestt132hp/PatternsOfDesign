namespace PatternsOfDesign.generative_patterns.Prototype.Shapes
{
    class Triangle:Shape
    {
        private readonly double _aHeight;
        private readonly double _bHeight;
        private readonly double _cWidth;
        private readonly string _color;
        private readonly bool _3d;
        public override Shape Clone()
        {
            return new Triangle(this);
        }

        private Triangle(Triangle triangle)
        {
            _aHeight = triangle._aHeight;
            _bHeight = triangle._bHeight;
            _cWidth = triangle._cWidth;
            _color = triangle._color;
            _3d = triangle._3d;
        }

        public Triangle(double aHeight, double bHeight)
        {
            _aHeight = aHeight;
            _bHeight = bHeight;
            _cWidth = _aHeight + _bHeight;
        }

        public Triangle(double aHeight, double bHeight, string color, bool dimension)
        {
            _aHeight = aHeight;
            _bHeight = bHeight;
            _color = color;
            _cWidth = aHeight + bHeight;
            _3d = dimension;
        }
    }
}
