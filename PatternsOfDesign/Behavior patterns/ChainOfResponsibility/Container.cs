
using System.Collections.Generic;

namespace PatternsOfDesign.Behavior_patterns.ChainOfResponsibility
{
    class Container:Component
    {
        private readonly List<Component> _children;

        public Container(string helpText) : base(helpText)
        {
            _children = new List<Component>();
        }

        public void Add(Component component)
        {
            _children.Add(component);
            component.Container = this;
        }

        public List<Component> GetComponents => _children;
    }
}
