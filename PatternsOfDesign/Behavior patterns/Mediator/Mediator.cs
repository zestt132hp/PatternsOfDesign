
using System;

namespace PatternsOfDesign.Behavior_patterns.Mediator
{
    interface IMediator
    {
        void Notify(object sender, EventArgs e);
    } 
}
