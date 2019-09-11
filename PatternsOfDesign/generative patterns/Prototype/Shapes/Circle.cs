
namespace PatternsOfDesign.generative_patterns.Prototype.Shapes
{
    class Circle:Shape
    {

        private readonly double _radius;
        private readonly string _color;
        private readonly bool _3d;

        public override Shape Clone()
        {
            return new Circle(this);
        }

        private Circle(Circle circle)
        {
            _color = circle._color;
            _radius = circle._radius;
            _3d = circle._3d;
        }

        public Circle(double radius, bool dimension, string color = "black")
        {
            _radius = radius;
            _color = color;
            _3d = dimension;
        }

        public Circle(double radius)
        {
            _radius = radius;
        }
    }
}
