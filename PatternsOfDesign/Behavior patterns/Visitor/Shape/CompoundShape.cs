using System;

namespace PatternsOfDesign.Behavior_patterns.Visitor.Shape
{
    class CompoundShape:IShape
    {
        public void Move(int x, int y)
        {
            Console.WriteLine($"Moving Compound to {x}:{y}");
        }

        public void Draw()
        {
            Console.WriteLine("Drawing");
        }

        public void Accept(IVisitor v)
        {
            v.VisitCompoundShape(this);
        }
    }
}
