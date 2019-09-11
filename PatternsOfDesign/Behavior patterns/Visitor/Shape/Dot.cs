using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsOfDesign.Behavior_patterns.Visitor.Shape
{
    class Dot:IShape
    {
        public void Move(int x, int y)
        {
            Console.Write($"Moving to {x}:{y}");
        }

        public void Draw()
        {
            Console.WriteLine("Drawing");
        }

        public virtual void Accept(IVisitor v)
        {
            v.VisitDot(this);
        }
    }
}
