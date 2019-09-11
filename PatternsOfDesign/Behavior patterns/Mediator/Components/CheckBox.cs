
using System;

namespace PatternsOfDesign.Behavior_patterns.Mediator.Components
{
    class CheckBox:Component
    {
        private IMediator _mediator;
        public CheckBox(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        public void Check()
        {
            _mediator.Notify(this, new EventArgs());
        }
    }
}
