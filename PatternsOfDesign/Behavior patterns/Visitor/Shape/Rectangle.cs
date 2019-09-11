
using System;

namespace PatternsOfDesign.Behavior_patterns.Visitor.Shape
{
    class Rectangle:IShape
    {
        public void Move(int x, int y)
        {
            Console.WriteLine($"Move rectangle to dot: {x}:{y}");
        }

        public void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }

        public void Accept(IVisitor v)
        {
            v.VisitRectangle(this);
        }
    }
}
