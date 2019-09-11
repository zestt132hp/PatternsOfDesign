
using System;

namespace PatternsOfDesign.structure_patterns.Composite
{
    class Circle:Dot
    {
        private readonly double _radius;
        public Circle(int x, int y, double radius) : base(x, y)
        {
            _radius = radius;
        }

        public new void Draw()
        {
            base.Draw();
            Console.WriteLine($"Circle drawing dot with radius {_radius}");
        }
    }
}
