
using PatternsOfDesign.Behavior_patterns.Strategy.Strategies;

namespace PatternsOfDesign.Behavior_patterns.Strategy
{
    class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ChangeStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public int ExecuteStrategy(int a, int b)
        {
            return _strategy.Execute(a, b);
        }
    }
}
