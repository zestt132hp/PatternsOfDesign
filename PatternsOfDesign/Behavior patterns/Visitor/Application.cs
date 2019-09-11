
using System.Collections.Generic;
using PatternsOfDesign.Behavior_patterns.Visitor.Shape;

namespace PatternsOfDesign.Behavior_patterns.Visitor
{
    class Application
    {
        private readonly List<IShape> _list;
        private IVisitor _visitor;

        public Application()
        {
            _list = new List<IShape>();
        }

        public void Export()
        {
            _visitor = new XmlExportVisitor();
            foreach (var shape in _list)
            {
                shape.Accept(_visitor);
            }
        }

    }
}
