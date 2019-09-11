using System;
using PatternsOfDesign.structure_patterns.Adapter.Peg;

namespace PatternsOfDesign.structure_patterns.Adapter
{
    class SquarePegAdapter:RoundPeg
    {
        private SquarePage _square;

        public SquarePegAdapter(double radius) : base(radius)
        {
        }

        public SquarePegAdapter(SquarePage squarePage)
        {
            _square = squarePage;
        }

        public new double GetRadius()
        {
            return Math.Sqrt(2 * Math.Pow(_square.GetWidth, 2)) / 2;
        }
    }
}
