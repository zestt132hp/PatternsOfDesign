using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsOfDesign.Builder
{
    class Director
    {
        public Director(IBuilder builder)
        {
            builder.Reset();
            builder.SetEngine(5000);
            builder.SetGps();
            builder.SetMonitor();
            builder.SetSeats(2);
        }
    }
}
