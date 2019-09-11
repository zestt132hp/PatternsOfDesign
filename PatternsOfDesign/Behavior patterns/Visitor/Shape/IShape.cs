
namespace PatternsOfDesign.Behavior_patterns.Visitor.Shape
{
    interface IShape
    {
        void Move(int x, int y);
        void Draw();
        void Accept(IVisitor v);
    }
}
