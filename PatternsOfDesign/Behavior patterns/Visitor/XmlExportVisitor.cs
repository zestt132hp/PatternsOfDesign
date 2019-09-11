using System;
using PatternsOfDesign.Behavior_patterns.Visitor.Shape;

namespace PatternsOfDesign.Behavior_patterns.Visitor
{
    class XmlExportVisitor:IVisitor
    {
        public void VisitDot(Dot d)
        {
            Console.WriteLine("export dot");
        }

        public void VisitCircle(Circle c)
        {

            Console.WriteLine("export circle");
        }

        public void VisitRectangle(Rectangle r)
        {

            Console.WriteLine("export rectangle");
        }

        public void VisitCompoundShape(CompoundShape shape)
        {

            Console.WriteLine("export compound");
        }
    }
}
