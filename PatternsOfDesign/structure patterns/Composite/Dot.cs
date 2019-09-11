using System;


namespace PatternsOfDesign.structure_patterns.Composite
{
    class Dot:IGraphic
    {
        private int _x;
        private int _y;

        public Dot(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public void Move(int x, int y)
        {
            _x += x;
            _y += y;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing dot with coordinate {_x}{_y}");

        }
    }
}
