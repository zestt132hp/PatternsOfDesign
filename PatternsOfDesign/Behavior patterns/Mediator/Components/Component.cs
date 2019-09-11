using System;

namespace PatternsOfDesign.Behavior_patterns.Mediator.Components
{
    class Component
    {
        private readonly IMediator _mediator;
        public Component(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Click()
        {
            _mediator.Notify(this, new EventArgs());
        }

        public void Check()
        {
            _mediator.Notify(this, new EventArgs());
        }
    }
}
