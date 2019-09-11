
namespace PatternsOfDesign.Behavior_patterns.Strategy.Strategies
{
    class StrategyAdd:IStrategy
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
