using System.Collections.Generic;

namespace PatternsOfDesign.structure_patterns.Composite
{
    class CompoundGraphic:IGraphic
    {
        private IList<IGraphic> _childrens;

        public CompoundGraphic()
        {
            _childrens = new List<IGraphic>();
        }
        public void Add(IGraphic children)
        {
            _childrens.Add(children);
        }

        public void Remove(IGraphic children)
        {
            _childrens.Remove(children);
        }

        public void Move(int x, int y)
        {
            foreach (var children in _childrens)
            {
               children.Move(x, y); 
            }
        }

        public void Draw()
        {
            foreach (var children in _childrens)
            {
                children.Draw();
            }
        }
    }
}
