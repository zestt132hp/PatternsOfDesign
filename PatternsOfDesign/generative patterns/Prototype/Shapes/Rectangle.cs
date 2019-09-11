
namespace PatternsOfDesign.generative_patterns.Prototype.Shapes
{
    class Rectangle:Shape
    {

        private readonly double _width;
        private readonly double _height;
        private readonly string _color;
        private readonly bool _3d;
        public override Shape Clone()
        {
            return new Rectangle(this);
        }

        private Rectangle(Rectangle rectangle)
        {
            _width = rectangle._width;
            _height = rectangle._height;
            _3d = rectangle._3d;
            _color = rectangle._color;
        }

        public Rectangle(double width, double height, string color, bool dimension)
        {
            _3d = dimension;
            _width = width;
            _height = height;
            _color = color;
        }

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }
    }
}
