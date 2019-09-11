using System;
using System.Threading;

namespace PatternsOfDesign.Behavior_patterns.Strategy.Strategies
{
    class StrategyDivide:IStrategy
    {
        public int Execute(int a, int b)
        {
            if (a > 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Divide on zero impossible, will be throw Error");
                Thread.Sleep(500);
                throw new DivideByZeroException(nameof(a));
            }
        }
    }
}
