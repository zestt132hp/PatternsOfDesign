namespace PatternsOfDesign.Behavior_patterns.Visitor.Shape
{
    class Circle:Dot
    {
        public override void Accept(IVisitor v)
        {
            v.VisitCircle(this);
        }
    }
}
