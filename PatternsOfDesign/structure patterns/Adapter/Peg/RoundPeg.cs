using System;

namespace PatternsOfDesign.structure_patterns.Adapter.Peg
{
    class RoundPeg
    {
        private double _radius;

        public RoundPeg(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException(nameof(radius));
            }

            _radius = radius;
        }

        protected RoundPeg()
        {
        }

        public double GetRadius => _radius;
    }
}
