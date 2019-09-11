using System;

namespace PatternsOfDesign.structure_patterns.Adapter.Peg
{
    class RoundHole
    {
        private double _radius;
        public RoundHole(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException(nameof(radius));
            }

            _radius = radius;
        }

        public double GetRadius => _radius;

        public bool Fits(RoundPeg roundPeg)
        {
            return GetRadius >= roundPeg.GetRadius;
        }

    }
}
