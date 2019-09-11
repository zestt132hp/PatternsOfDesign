
namespace PatternsOfDesign.Behavior_patterns.Strategy.Strategies
{
    class StrategyMultiply:IStrategy
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
