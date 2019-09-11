
using PatternsOfDesign.Behavior_patterns.Visitor.Shape;

namespace PatternsOfDesign.Behavior_patterns.Visitor
{
    interface IVisitor
    {
        void VisitDot(Dot d);
        void VisitCircle(Circle c);
        void VisitRectangle(Rectangle r);
        void VisitCompoundShape(CompoundShape shape);
    }
}
